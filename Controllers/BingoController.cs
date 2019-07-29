using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebApi.Helpers;
using WebApi.Entities;

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
        public IEnumerable<Ball> InitGame(int startNumber, int endNumber)
        {
            var arr = new List<Ball>();
            for (var i = startNumber; i <= endNumber; i++)
            {
                arr.Add(new Ball()
                {
                    NumValue = i.ToString(),
                    IsPlayed = false
                });
            }
            _context.AddRange(entities: arr);
            _context.SaveChanges();
            return arr.ToArray();
        }
        [HttpGet("playCards")]
        public IActionResult Get(List<int> cards)
        {
            var myCards = _context.Card.Where(c => cards.Contains(c.Id)).ToArray();
            //var rows = _context.Rows.Where(r => cards.Contains(r.CardID)).OrderBy(r=>r.CardID).ThenBy(r=>r.Id).ToArray();
            List<Match> matches = new List<Match>();
            for (var i = 0; i < myCards.Count(); i++)
            {
                var rows = myCards[i].Rows.ToList();
                rows.Add(myCards[i].OnDiagonal);
                rows.Add(myCards[i].OffDiagonal);
                // should have seven possible win rows to add to the match table, MARK TO DO: UNIT TEST THIS
                for (var j = 0; j < rows.Count(); j++)
                {
                    Match match = new Match()
                    {
                        B = rows[i].B,
                        I = rows[i].I,
                        N = rows[i].N,
                        G = rows[i].G,
                        O = rows[i].O,
                        CardID = rows[i].CardID,
                        RowId = rows[i].Id
                    };
                     _context.Match.Add(match);
                }
            }
            try
            {
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                Ok(ex.ToString());
            }
            return Ok("SUCCESS!");
        }
        [HttpGet("blowBalls")]
        public IActionResult BlowBallsAsync()
        {
            try
            {
                var rng = new Random();
                var myBalls = _context.Balls.Where(b => b.IsPlayed == false).ToArray();
                var index = rng.Next(myBalls.Length);
                myBalls[index].IsPlayed = true;
                myBalls[index].Updated = DateTime.Now;
                _context.SaveChanges();
                return Ok("Last blown ball: " + DateTime.Now.ToString());
            }
            catch (Exception ex)
            {
                return Ok("Ball blowing failure: " + ex.ToString());
            }
        }
        [HttpGet("[action]")]
        public IActionResult StartGame()
        {
            Ball[] balls = _context.Balls.ToArray();
            foreach (Ball ball in balls)
            {
                ball.IsPlayed = false;
            }
            _context.SaveChanges();
            return Ok();
        }
        [HttpGet("[action]")]
        public IEnumerable<string> Balls()
        {
            return _context.Balls.Where(x => x.IsPlayed).OrderByDescending(x => x.Updated).Select(item => item.NumValue).ToArray();
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
            bingoCard.Rows = rows;
                    // 5th row, build the diagonal matches
            Row onDiagonal = new Row(){
                B = rows[0].B,
                I = rows[1].I,
                N = rows[2].N,
                G = rows[3].G,
                O = rows[4].O,
                CardID = rows[0].CardID,
            };
            Row offDiagonal = new Row(){
                B = rows[4].B,
                I = rows[3].I,
                N = rows[2].N,
                G = rows[1].G,
                O = rows[0].O,
                CardID = rows[0].CardID,
            };
            bingoCard.OnDiagonal = onDiagonal;
            bingoCard.OffDiagonal = offDiagonal;
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
