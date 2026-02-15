using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Serilog;

namespace SerilogConsoleAppGenericHost
{
    public class HostExamples
    {
        public static void HostWithoutSerilog()
        {
            var hostBuilder = Host.CreateDefaultBuilder()
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddTransient<ClassWithSerilog>();
                    services.AddTransient<ClassWithMicrosoftLogger>();
                });

            var host = hostBuilder.Build();
            var service = host.Services.GetRequiredService<ClassWithMicrosoftLogger>();
            service.Execute();
        }

        public static void HostSerilogWithoutConfiguration()
        {
            var hostBuilder = Host.CreateDefaultBuilder()
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddSingleton(Log.Logger);
                    services.AddTransient<ClassWithSerilog>();
                    services.AddTransient<ClassWithMicrosoftLogger>();
                })
                .UseSerilog()
                ;

            var host = hostBuilder.Build();
            var service = host.Services.GetRequiredService<ClassWithMicrosoftLogger>();
            service.Execute();
            var service2 = host.Services.GetRequiredService<ClassWithSerilog>();
            service2.Execute();
        }

        public static void HostSerilogJsonConfiguration()
        {
            var hostBuilder = Host.CreateDefaultBuilder()
                .ConfigureAppConfiguration(config =>
                {
                    config.AddJsonFile("appsettings.Development.json", optional: true);
                })
                .ConfigureServices((hostContext, services) =>
                {
                    IConfiguration config = hostContext.Configuration;
                    Log.Logger = new LoggerConfiguration()
                        .ReadFrom.Configuration(config)
                        .Enrich.FromLogContext()
                        .WriteTo.Console()
                        .CreateLogger();

                    services.AddSingleton(Log.Logger);
                    services.AddTransient<ClassWithSerilog>();
                    services.AddTransient<ClassWithMicrosoftLogger>();
                })
                .UseSerilog()
                ;

            var host = hostBuilder.Build();
            var service = host.Services.GetRequiredService<ClassWithMicrosoftLogger>();
            service.Execute();
            var service2 = host.Services.GetRequiredService<ClassWithSerilog>();
            service2.Execute();
        }
    }
}
