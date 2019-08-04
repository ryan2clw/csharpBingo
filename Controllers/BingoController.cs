using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SpaBingo.Helpers;
using SpaBingo.Entities.Bingo;
using Microsoft.EntityFrameworkCore;

namespace SpaBingo.Controllers
{
    [Route("api/[controller]")]
    public class BingoController : Controller
    {
        private DataContext _context;
        private readonly BallBlower _ballBlower;

        public BingoController(DataContext context, BallBlower ballBlower)
        {
            _ballBlower = ballBlower;
            _context = context;
        }

        private static string[] BallNumbers(int min, int max)
        {
            var arr = new List<string>();
            for (var i = min; i < max; i++)
            {
                arr.Add(i.ToString());
            }
            return arr.ToArray();
        }
        [HttpGet("[action]")]
        public IEnumerable<GameNumber> InitGame(int? startNumber = 1, int? endNumber = 75)
        {
            var arr = new List<GameNumber>();
            for (var i = startNumber; i <= endNumber; i++)
            {
                arr.Add(new GameNumber()
                {
                    NumValue = i.ToString()
                });
            }
            _context.GameNumbers.AddRange(arr);
            _context.SaveChanges();
            return arr.ToArray();
        }
        [HttpGet("playCards")]
        public IActionResult Get(List<int> cards)
        {
            var myCards = _context.Card.Where(c => cards.Contains(c.Id)).Include(c => c.Rows).ToArray();
            List<Match> matches = new List<Match>();
            for (var i = 0; i < myCards.Count(); i++)
            {
                var rows = myCards[i].Rows.ToList();
                // should have 12 possible win rows to add to the match table,
                // add column wins
                // MARK TO DO: UNIT TEST THIS
                for (var j = 0; j < rows.Count(); j++)
                {
                    Match match = new Match()
                    {
                        B = rows[j].B,
                        I = rows[j].I,
                        N = rows[j].N,
                        G = rows[j].G,
                        O = rows[j].O,
                        CardID = rows[j].CardID
                    };
                    try
                    {
                        _context.Add(match);
                        _context.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        Ok(ex.ToString());
                    }
                }
            }
            return Ok("SUCCESS!");
        }
        private void nextBall()
        {
            // moves number from GameNumber
            var rng = new Random();
            var availableGameNumbers = _context.GameNumbers.ToArray();
            var index = rng.Next(availableGameNumbers.Length);
            var oneNut = availableGameNumbers[index];
            var currentBall = new Ball()
            {
                Updated = DateTime.Now,
                NumValue = oneNut.NumValue,
            };
            _context.Balls.Add(currentBall);
            _context.GameNumbers.Remove(oneNut);
            _context.SaveChanges();
            /*
             * Blow balls above, match balls below
             */
            int numValue = int.Parse(currentBall.NumValue);
            List<Match> matches = new List<Match>();
            matches.AddRange(_context.Match.Where(m => m.B == currentBall.NumValue).ToArray());
            matches.AddRange(_context.Match.Where(m => m.I == currentBall.NumValue).ToArray());
            matches.AddRange(_context.Match.Where(m => m.N == currentBall.NumValue).ToArray());
            matches.AddRange(_context.Match.Where(m => m.G == currentBall.NumValue).ToArray());
            matches.AddRange(_context.Match.Where(m => m.O == currentBall.NumValue).ToArray());
            for (var i = 0; i < matches.Count(); i++)
            {
                BallMatch ballMatch = new BallMatch()
                {
                    Ball = currentBall,
                    BallId = currentBall.Id,
                    Match = matches[i],
                    MatchId = matches[i].Id
                };
                matches[i].Left = matches[i].Left - 1;
                _context.Match.Update(matches[i]);
                _context.BallMatch.Add(ballMatch);
                _context.SaveChanges();
            }
        }
        [HttpGet("blowBalls")]
        public IActionResult BlowBallsAsync()
        {
            try
            {
                nextBall();
                return Ok("SUCCESS!");//Last blown ball: " + currentBall.NumValue + ", time: " + currentBall.Updated);
            }
            catch (Exception ex)
            {
                return Ok("Ball blowing failure: " + ex);
            }
        }
        [HttpGet("[action]")]
        public IActionResult CheckBingo(List<int> cards)
        {

            //List<List<Match>> cardMatches = new List<List<Match>>();
            Dictionary<int, int> CardHasHowManyLeft = new Dictionary<int, int>();
            CardHasHowManyLeft.Add(600, 5);
            CardHasHowManyLeft.Add(599, 5);
            CardHasHowManyLeft.Add(598, 5);
            CardHasHowManyLeft.Add(597, 5);
            CardHasHowManyLeft.Add(596, 5);
            CardHasHowManyLeft.Add(595, 5);
            Match[] matches = _context.Match.ToArray();
            for (var j = 0; j < matches.Count(); j++)
            {
                int oldLeft = CardHasHowManyLeft[matches[j].Left];
                if (matches[j].Left < oldLeft)
                {
                    CardHasHowManyLeft[matches[j].CardID] = matches[j].Left;
                }
            }
            return Ok(CardHasHowManyLeft);
        }
        [HttpGet("[action]")]
        public IActionResult StartGame()
        {// removes calledBalls, unCalledBalls, and Matches from the tables then loads fresh numbers into the machine
            Ball[] balls = _context.Balls.ToArray();
            GameNumber[] gameNumbers = _context.GameNumbers.ToArray();
            BallMatch[] ballMatches = _context.BallMatch.ToArray();
            var rowsInPlay = _context.Match.ToList();
            foreach (var row in rowsInPlay)
            {
                row.Left = row.NeededToWin;  // MARK TO DO: USE BULK UPDATE OR INSTALL DAPPER FOR SP
                _context.Match.Update(row);
            }
            _context.Balls.RemoveRange(balls);
            _context.GameNumbers.RemoveRange(gameNumbers);
            _context.BallMatch.RemoveRange(ballMatches);
            _context.SaveChanges();
            InitGame(); // by default loads 75 numbers into the GameNumbers Table
            return Ok();
        }
        [HttpGet("[action]")]
        public IActionResult Balls()
        {
            List<int> cards = new List<int>() { 600, 599, 598, 597, 596, 595 }; // MARK TO DO: REMOVE HARD CODED CARDS
            var json = new RoundJSON();
            json.BallsBlown = _context.Balls.OrderByDescending(x => x.Updated).Select(item => item.NumValue).ToArray();
            Dictionary<int, int> CardHasHowManyLeft = new Dictionary<int, int>();
            for (var i = 0; i < cards.Count; i++)
            {
                List<Match> matches = _context.Match.Where(m => m.CardID == cards[i]).ToList();
                for (var j = 0; j < matches.Count; j++)
                {
                    if (!CardHasHowManyLeft.Keys.Contains(matches[i].CardID))
                    {
                        CardHasHowManyLeft.Add(matches[i].CardID, matches[i].Left);
                    }
                    else
                    {   // prevent dictionary key crash, take smallest value
                        var newLeft = matches[i].Left;
                        if(newLeft<CardHasHowManyLeft[matches[i].CardID]){
                            CardHasHowManyLeft[matches[i].CardID] = matches[i].Left;
                        }
                    }
                }
                json.NumbersLeftOnCard = CardHasHowManyLeft;
            }
            return Ok(json);
        }
        //private Card BingoCard(int cardID)
        //{
        //    return _context.Card.Where(c => c.Id == cardID).FirstOrDefault();
        //}
        private Card SeedBingoCard()
        {
            var rng = new Random();
            var b = BallNumbers(1, 15).ToList();
            var i = BallNumbers(16, 30).ToList();
            var n = BallNumbers(31, 45).ToList();
            var g = BallNumbers(46, 60).ToList();
            var o = BallNumbers(61, 75).ToList();
            Card bingoCard = new Card();
            var ret = (Enumerable.Range(1, 5).Select(index =>
            {
                var bRemove = rng.Next(b.Count);
                var iRemove = rng.Next(i.Count);
                var nRemove = rng.Next(n.Count);
                var gRemove = rng.Next(g.Count);
                var oRemove = rng.Next(o.Count);
                Row innerRet = new Row()
                {
                    B = b[bRemove],
                    I = i[iRemove],
                    N = n[nRemove],
                    G = g[gRemove],
                    O = o[oRemove],
                    CardID = bingoCard.Id
                };
                b.RemoveAt(bRemove);
                i.RemoveAt(iRemove);
                n.RemoveAt(nRemove);
                g.RemoveAt(gRemove);
                o.RemoveAt(oRemove);
                return innerRet;
            }));
            var rows = ret.ToList();
            // 5th row, build the diagonal matches
            Row onDiagonal = new Row() {
                B = rows[0].B,
                I = rows[1].I,
                N = rows[2].N,
                G = rows[3].G,
                O = rows[4].O,
                CardID = rows[0].CardID,
            };
            Row offDiagonal = new Row() {
                B = rows[4].B,
                I = rows[3].I,
                N = rows[2].N,
                G = rows[1].G,
                O = rows[0].O,
                CardID = rows[0].CardID,
            };
            Row bColumn = new Row()
            {
                B = rows[4].B,
                I = rows[3].B,
                N = rows[2].B,
                G = rows[1].B,
                O = rows[0].B,
                CardID = rows[0].CardID,
            };
            Row iColumn = new Row()
            {
                B = rows[4].I,
                I = rows[3].I,
                N = rows[2].I,
                G = rows[1].I,
                O = rows[0].I,
                CardID = rows[0].CardID,
            };
            Row nColumn = new Row()
            {
                B = rows[4].N,
                I = rows[3].N,
                N = rows[2].N,
                G = rows[1].N,
                O = rows[0].N,
                CardID = rows[0].CardID,
            };
            Row gColumn = new Row()
            {
                B = rows[4].G,
                I = rows[3].G,
                N = rows[2].G,
                G = rows[1].G,
                O = rows[0].G,
                CardID = rows[0].CardID,
            };
            Row oColumn = new Row()
            {
                B = rows[4].O,
                I = rows[3].O,
                N = rows[2].O,
                G = rows[1].O,
                O = rows[0].O,
                CardID = rows[0].CardID,
            };
            rows.Add(bColumn);
            rows.Add(iColumn);
            rows.Add(nColumn);
            rows.Add(gColumn);
            rows.Add(oColumn);
            rows.Add(offDiagonal);
            rows.Add(onDiagonal);
            bingoCard.Rows = rows;
            try
            {
                _context.Card.Add(bingoCard);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw (ex); // fatal error, customer has no card
            }
            return bingoCard;
        }
        private FakeCard ScoreCard()
        {
            var myCard = new FakeCard();
            var myList = new List<FakeRow>();
            var B = 1;
            var I = 16;
            var N = 31;
            var G = 46;
            var O = 61;
            for (var i = 0; i < 15; i++)
            {
                myList.Add(new FakeRow()
                {
                    B = B.ToString(),
                    I = I.ToString(),
                    N = N.ToString(),
                    G = G.ToString(),
                    O = O.ToString()
                });
                B++;
                I++;
                N++;
                G++;
                O++;
            }
            myCard.Rows = myList;
            return myCard;
        }
        [HttpGet("[action]")]
        public IActionResult BingoCards(int cardCount)
        {
            CardData cardData = new CardData(); // Cards are persistent entities, the rest is for JSON
            FakeCard scoreCard = ScoreCard();
            cardData.ScoreCard = scoreCard;
            List<int> cards = new List<int>() { 600, 599, 598, 597, 596, 595 }; // MARK TO DO: REMOVE HARD CODED CARDS
            cardData.Cards = _context.Card.Where(c => cards.Contains(c.Id)).Include(c => c.Rows).ToList();
            return Ok(cardData);
        }
        public class CardData
        {
            public FakeCard ScoreCard { get; set; }
            public List<Card> Cards { get; set; }
        }
        public class RoundJSON
        {
            public string[] BallsBlown { get; set; }
            public Dictionary<int, int> NumbersLeftOnCard { get; set; }
        }

        public class FakeCard // non-persistent data
        {
            public List<FakeRow> Rows = new List<FakeRow>();
        }

        public class FakeRow
        {
            public string B { get; set; }
            public string I { get; set; }
            public string N { get; set; }
            public string G { get; set; }
            public string O { get; set; }
        }
    }
}
