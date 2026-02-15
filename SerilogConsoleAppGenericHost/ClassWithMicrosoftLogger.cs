using Microsoft.Extensions.Logging;

namespace SerilogConsoleAppGenericHost
{
    public class ClassWithMicrosoftLogger
    {
        private readonly ILogger<ClassWithMicrosoftLogger> _logger;

        public ClassWithMicrosoftLogger(ILogger<ClassWithMicrosoftLogger> logger)
        {
            _logger = logger;
        }

        public void Execute(CancellationToken stoppingToken = default)
        {
            _logger.LogInformation(TextForLogging.Information);
            _logger.LogDebug(TextForLogging.Debug);
            _logger.LogWarning(TextForLogging.Warning);
            _logger.LogError(TextForLogging.Error);
        }
    }
}
