using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Serilog;

namespace SerilogConsoleAppGenericHost
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Log.Logger = new LoggerConfiguration()
                .WriteTo.Console()
                .CreateLogger();


            var hostBuilder = Host.CreateDefaultBuilder()
               .ConfigureAppConfiguration(config =>
               {
                   config.AddJsonFile("appsettings.Development.json", optional: true);
               })
               .ConfigureServices((hostContext, services) =>
               {
                   services.AddTransient<ClassWithSerilog>();
                   services.AddTransient<ClassWithMicrosoftLogger>();

                   //services.AddSerilog();

                   //IConfiguration config = hostContext.Configuration;
                   //Log.Logger = new LoggerConfiguration()
                   //    .ReadFrom.Configuration(config)
                   //    .Enrich.FromLogContext()
                   //    .WriteTo.Console()
                   //    .CreateLogger();
               })
               //.UseSerilog()
               ;

            var host = hostBuilder.Build();
            var service = host.Services.GetRequiredService<ClassWithMicrosoftLogger>();
            service.ExecuteAsync().Wait();
        }

        static void RunHost1()
        {
            var hostBuilder = Host.CreateDefaultBuilder()
                .ConfigureAppConfiguration(config =>
                {
                    config.AddJsonFile("appsettings.Development.json", optional: true);
                })
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddTransient<ClassWithSerilog>();
                    services.AddTransient<ClassWithMicrosoftLogger>();

                    IConfiguration config = hostContext.Configuration;
                    Log.Logger = new LoggerConfiguration()
                        .ReadFrom.Configuration(config)
                        .Enrich.FromLogContext()
                        .WriteTo.Console()
                        .CreateLogger();
                })
                .UseSerilog()
                ;

            var host = hostBuilder.Build();
            var service = host.Services.GetRequiredService<ClassWithMicrosoftLogger>();
            service.ExecuteAsync().Wait();
        }

        static void RunHost2()
        {
            var hostBuilder = Host.CreateDefaultBuilder()
                .ConfigureAppConfiguration(config =>
                {
                    config.AddJsonFile("appsettings.Development.json", optional: true);
                })
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddTransient<ClassWithSerilog>();
                    services.AddTransient<ClassWithMicrosoftLogger>();

                    IConfiguration config = hostContext.Configuration;
                    Log.Logger = new LoggerConfiguration()
                        .ReadFrom.Configuration(config)
                        .Enrich.FromLogContext()
                        .WriteTo.Console()
                        .CreateLogger();
                })
                .UseSerilog()
                ;

            var host = hostBuilder.Build();
            var service = host.Services.GetRequiredService<ClassWithMicrosoftLogger>();
            service.ExecuteAsync().Wait();
        }
    }



   
}
