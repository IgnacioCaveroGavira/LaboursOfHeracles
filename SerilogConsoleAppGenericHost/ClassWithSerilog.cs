using Serilog;

namespace SerilogConsoleAppGenericHost
{
    public class ClassWithSerilog
    {
        private readonly ILogger _logger;

        public ClassWithSerilog(ILogger logger)
        {
            _logger = logger;
        }

        public async Task ExecuteAsync(CancellationToken stoppingToken = default)
        {
            _logger.Information("ClassWithSerilog log");
        }
    }
}
