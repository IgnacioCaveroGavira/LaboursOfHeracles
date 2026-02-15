using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace DependencyInjection
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine();

            var builder = Host.CreateApplicationBuilder();

            var myClass = new MyClass("Susan", 22);
            builder.Services.AddSingleton(myClass); //This is like builder.Services.AddSingleton<MyClass>(myClass)
            builder.Services.AddTransient<MyClassService>();


            IHello helloInterface = new MyClass("Tom", 33);
            builder.Services.AddSingleton(helloInterface);
            //builder.Services.AddSingleton(myClass as IHello);
            builder.Services.AddTransient<HelloService>();


            var host = builder.Build();

            var classService = host.Services.GetRequiredService<MyClassService>();
            classService.SayInfo();
            

            var helloService = host.Services.GetRequiredService<HelloService>();
            helloService.SayInfo();
        }
    }
}
