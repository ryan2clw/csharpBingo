using System;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using WebApi.Entities;
using WebApi.Helpers;

public class BallBlower
{
    private const string blowBallsUri = "http://localhost:5000/api/Bingo/blowBalls";
    private readonly HttpClient _httpClient;
    public BallBlower()
    {
        _httpClient = new HttpClient();
    }
    public async Task UpdateString(CancellationToken cancellationToken)
    {
        try
        {
            var response = await _httpClient.GetAsync(blowBallsUri, cancellationToken);
            if (response.IsSuccessStatusCode)
            {
                RandomString = await response.Content.ReadAsStringAsync();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
        }
    }
    public string RandomString { get; private set; } = string.Empty;
}