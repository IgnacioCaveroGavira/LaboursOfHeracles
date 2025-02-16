using Microsoft.Extensions.Hosting;

namespace ConsoleHost
{
    public class Service1 : IHostedService
    {
        public async Task StartAsync(CancellationToken cancellationToken)
        {
            Console.WriteLine("Iniciando Servicio1");
            await Task.Delay(3000); // Simula trabajo
            Console.WriteLine("Servicio1 iniciado");
        }

        public async Task StopAsync(CancellationToken cancellationToken)
        {
            Console.WriteLine("Deteniendo Servicio1");
            await Task.Delay(4000);
        }
    }

    public class Service2 : IHostedService
    {
        public async Task StartAsync(CancellationToken cancellationToken)
        {
            Console.WriteLine("Iniciando Servicio2");
            await Task.Delay(3000); // Simula trabajo
            Console.WriteLine("Servicio2 iniciado");
        }

        public async Task StopAsync(CancellationToken cancellationToken)
        {
            Console.WriteLine("Deteniendo Servicio2");
            await Task.Delay(4000);
        }
    }
}