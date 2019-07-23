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

        public BingoController(DataContext context){
            _context = context;
        }

        private static string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };
        private static string[] BallNumbers(int min, int max)
        {
            var arr = new List<string>();
            for(var i =min; i <max; i++){
                arr.Add(i.ToString());
            }
            return arr.ToArray();
        }
        [HttpGet("[action]")]
        public IEnumerable<BingoNumber> InitGame(int startNumber, int endNumber)
        {
            var arr = new List<BingoNumber>();
            for (var i = startNumber; i <= endNumber; i++)
            {
                arr.Add(new BingoNumber()
                {
                    NumValue = i.ToString(),
                    IsPlayed = false
                });
            }
            _context.AddRange(entities: arr);
            _context.SaveChanges();
            return arr.ToArray();
        }
        [HttpGet("[action]")]
        public IActionResult StartGame()
        {
            BingoNumber[] numBas = _context.BingoNumbers.ToArray();
            foreach (BingoNumber numBa in numBas)
            {
                numBa.IsPlayed = false;
            }
            _context.SaveChanges();
            //Thread t = new Thread(()=>{
             BlowBalls();
            //});
            //t.Start();
            //ThreadPool.QueueUserWorkItem(x => BlowBalls());
            return Ok();
        }
        // Blows Balls once every 5 seconds for 6.25 minutes
        private void BlowBalls()
        {
            var startTime = DateTime.UtcNow;
            while (DateTime.UtcNow - startTime < TimeSpan.FromMinutes(7))
            {
                System.Threading.Thread.Sleep(5000);
                var rng = new Random();
                var myBalls = _context.BingoNumbers.Where(b => b.IsPlayed == false).ToArray();
                var index = rng.Next(myBalls.Length);
                myBalls[index].IsPlayed = true;
                myBalls[index].Updated = DateTime.Now;
                _context.SaveChanges();
            }
        }
        [HttpGet("[action]")]
        public IEnumerable<string> GetNumbas()
        {
            return _context.BingoNumbers.Where(x => x.IsPlayed).OrderByDescending(x=>x.Updated).Select(item => item.NumValue).ToArray();
        }
        [HttpGet("[action]")]
        public string GetNumba()
        {
            return _context.BingoNumbers.Where(x => x.IsPlayed).OrderByDescending(x=>x.Updated).Select(item => item.NumValue).FirstOrDefault();
        }
        private Card BingoCard()
        {
            var rng = new Random();
            var b = BallNumbers(1, 15);
            var i = BallNumbers(16, 30);
            var n = BallNumbers(31,45);
            var g = BallNumbers(46,60);
            var o = BallNumbers(61, 75);
            Card bingoCard = new Card();
            var ret = (Enumerable.Range(1, 5).Select(index => new Row
            {
                B = b[rng.Next(b.Length)],
                I = i[rng.Next(i.Length)],
                N = n[rng.Next(n.Length)],
                G = g[rng.Next(g.Length)],
                O = o[rng.Next(o.Length)]
            }));
            bingoCard.Rows = ret.ToList();
            return bingoCard;
        }
        private Card ScoreCard()
        {
            var myCard=  new Card();
            var myList = new List<Row>();
            var B = 1;
            var I = 16;
            var N = 31;
            var G = 46;
            var O = 61;
            for(var i=0;i<15;i++){
                myList.Add(new Row(){
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
            CardData cardData = new CardData();
            Card scoreCard = ScoreCard();
            cardData.ScoreCard = scoreCard;
            List<Card> cards = new List<Card>();
            for(var j =0; j <cardCount; j++){
                Card newCard = BingoCard();
                cards.Add(newCard);
            }
            cardData.Cards = cards;
            return Ok(cardData);
        }

        [HttpGet("[action]")]
        public IEnumerable<WeatherForecast> WeatherForecasts(int startDateIndex)
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                DateFormatted = DateTime.Now.AddDays(index + startDateIndex).ToString("d"),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            });
        }
        public class CardData
        {
            public Card ScoreCard { get; set; }
            public List<Card> Cards { get; set; }
        }
        public class Card
        {
            public List<Row> Rows = new List<Row>();
        }
        public class Row        
        {
            public string B { get; set; }
            public string I { get; set; }
            public string N { get; set; }
            public string G { get; set; }
            public string O { get; set; }

        }
        public class WeatherForecast
        {
            public string DateFormatted { get; set; }
            public int TemperatureC { get; set; }
            public string Summary { get; set; }

            public int TemperatureF
            {
                get
                {
                    return 32 + (int)(TemperatureC / 0.5556);
                }
            }
        }
    }
}
