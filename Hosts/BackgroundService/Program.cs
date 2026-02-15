using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace ConsoleHost
{
    public class Program
    {
        public static void Main(string[] args)
        {
            HostApplicationBuilder hostBuilder = new HostApplicationBuilder();

            hostBuilder.Services.AddHostedService<Service1>();
            hostBuilder.Services.AddHostedService<BackgroundServiceCount>();
            hostBuilder.Services.AddHostedService<Service2>();
        
            IHost host = hostBuilder.Build();

            host.Run();
        }
    }
}

/*
Los IHostedService se ejecutan secuencialmente de manera que hasta que no termine StartAsync del Service1 no empieza el StartAsync del siguiente servicio (BackgroundServiceCount/Service2).
Por otro lado, el método ExecuteAsync de los BackgroundService comienza su ejecución cuando termina su propio StartAsync (que hereda de IHostedService), 
pero no espera a que ExecuteAsync termine para continuar con el siguiente servicio, 
ya que está diseñado para ejecutarse como un daemon (tarea en segundo plano de larga duración). 
 */