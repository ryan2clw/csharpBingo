using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SpaBingo.Controllers
{
    [Route("api/[controller]")]
    public class BingoController : Controller
    {
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
        public IEnumerable<Numba> BingoCard(int cardCount)
        {
            var rng = new Random();
            var b = BallNumbers(1, 15);
            var i = BallNumbers(16, 30);
            var n = BallNumbers(31,45);
            var g = BallNumbers(46,60);
            var o = BallNumbers(61, 75);
            return (Enumerable.Range(1, 5).Select(index => new Numba
            {
                B = b[rng.Next(b.Length)],
                I = i[rng.Next(i.Length)],
                N = n[rng.Next(n.Length)],
                G = g[rng.Next(g.Length)],
                O = o[rng.Next(o.Length)]
            }));
        }
        [HttpGet("[action]")]
        public IEnumerable<Numba> BingoCards(int cardCount)
        {
            // MARK TO DO: MAKE AN ARRAY OF CARDS
            // var arr = new List<Object>();
            // for(var j =0; j <cardCount; j++){
                var rng = new Random();
                var b = BallNumbers(1, 15);
                var i = BallNumbers(16, 30);
                var n = BallNumbers(31,45);
                var g = BallNumbers(46,60);
                var o = BallNumbers(61, 75);
                return (Enumerable.Range(1, 5).Select(index => new Numba
                {
                    B = b[rng.Next(b.Length)],
                    I = i[rng.Next(i.Length)],
                    N = n[rng.Next(n.Length)],
                    G = g[rng.Next(g.Length)],
                    O = o[rng.Next(o.Length)]
                }));
            // }
            // return arr.Cast;
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
        public class Card
        {
            public List<Numba> numbas = new List<Numba>();
        }
        public class Numba        
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
