using System;
using System.Threading;
using System.Threading.Tasks;

public class DataRefreshService : HostedService
{
    private readonly BallBlower _ballBlower;
    public DataRefreshService(BallBlower ballBlower)
    {
        _ballBlower = ballBlower;
    }

    protected override async Task ExecuteAsync(CancellationToken cancellationToken)
    {
        while (!cancellationToken.IsCancellationRequested)
        {
            await _ballBlower.UpdateString(cancellationToken);
            await Task.Delay(TimeSpan.FromSeconds(5), cancellationToken);
        }
    }
}