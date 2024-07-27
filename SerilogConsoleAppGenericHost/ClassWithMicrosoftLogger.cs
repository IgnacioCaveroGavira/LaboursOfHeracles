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

        public async Task ExecuteAsync(CancellationToken stoppingToken = default)
        {
            _logger.LogInformation($"_logger => ClassWithMicrosoftLogger log type: {_logger.GetType().Namespace}");
            Console.WriteLine($"Console => ClassWithMicrosoftLogger log type: {_logger.GetType().Namespace}");
        }
    }
}
