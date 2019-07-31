using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SpaBingo.Helpers;
using SpaBingo.Entities;
using Microsoft.EntityFrameworkCore;
using EFCore.BulkExtensions;

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
            _context.BulkInsert(arr);
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
        private Ball nextBall()
        {
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
            _context.SaveChanges();
            return currentBall;
        }
        private void matchBalls(Ball currentBall)
        {
            /* Blow balls above, match balls below
            Mark to do, try Bulk next
             */
            int numValue = int.Parse(currentBall.NumValue);
            List<Match> matches = new List<Match>();
            /* MARK TO DO: Fall back to check remaining columns, maybe make a computed property that accumulates the group of 5 values to an array, for the all "B" case, column match, also gotta add those rows */
            matches.AddRange(_context.Match.Where(m => m.B == currentBall.NumValue).ToList());
            matches.AddRange(_context.Match.Where(m => m.I == currentBall.NumValue).ToList());
            matches.AddRange(_context.Match.Where(m => m.N == currentBall.NumValue).ToList());
            matches.AddRange(_context.Match.Where(m => m.G == currentBall.NumValue).ToList());
            matches.AddRange(_context.Match.Where(m => m.O == currentBall.NumValue).ToList());

            for (var i = 0; i < matches.Count(); i++)
            {
                BallMatch ballMatch = new BallMatch()
                {
                    Ball = currentBall,
                    BallId = currentBall.Id,
                    Match = matches[i],
                    MatchId = matches[i].Id
                };
                _context.BallMatch.Add(ballMatch);
                _context.SaveChanges();
            }
        }
        [HttpGet("blowBalls")]
        public IActionResult BlowBallsAsync()
        {
            try
            {
                Ball currentBall = nextBall();
                matchBalls(currentBall);
                return Ok("Last blown ball: " + currentBall.NumValue + ", time: " + currentBall.Updated);
            }
            catch (Exception ex)
            {
                return Ok("Ball blowing failure: " + ex);
            }
        }
        [HttpGet("[action]")]
        public IActionResult StartGame()
        {
            Ball[] balls = _context.Balls.ToArray();
            _context.BulkDelete(balls);
            _context.SaveChanges();
            return Ok();
        }
        [HttpGet("[action]")]
        public IEnumerable<string> Balls()
        {
            return _context.Balls.OrderByDescending(x => x.Updated).Select(item => item.NumValue).ToArray();
        }
        private Card BingoCard()
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
            Row onDiagonal = new Row(){
                B = rows[0].B,
                I = rows[1].I,
                N = rows[2].N,
                G = rows[3].G,
                O = rows[4].O,
                CardID = rows[0].CardID,
            };
            rows.Add(onDiagonal);
            Row offDiagonal = new Row(){
                B = rows[4].B,
                I = rows[3].I,
                N = rows[2].N,
                G = rows[1].G,
                O = rows[0].O,
                CardID = rows[0].CardID,
            };
            rows.Add(offDiagonal);
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
            List<Card> cards = new List<Card>();
            for (var j = 0; j < cardCount; j++)
            {
                Card newCard = BingoCard();
                cards.Add(newCard);
            }
            cardData.Cards = cards;
            return Ok(cardData);
        }
        public class CardData
        {
            public FakeCard ScoreCard { get; set; }
            public List<Card> Cards { get; set; }
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
