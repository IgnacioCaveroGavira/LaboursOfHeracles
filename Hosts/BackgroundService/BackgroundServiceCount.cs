using Microsoft.Extensions.Hosting;

namespace ConsoleHost
{
    public class BackgroundServiceCount : BackgroundService
    {
        public int Count { get; set; }

        public BackgroundServiceCount()
        {
            Count = 1;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                Console.WriteLine($"Cuenta Test: {Count}");
                await Task.Delay(1000);
                Count++;
            }
        }
    }
}
