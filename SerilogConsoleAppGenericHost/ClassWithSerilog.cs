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

        public void Execute(CancellationToken stoppingToken = default)
        {
            _logger.Information(TextForLogging.Information);
            _logger.Debug(TextForLogging.Debug);
            _logger.Warning(TextForLogging.Warning);
            _logger.Error(TextForLogging.Error);
        }
    }
}
