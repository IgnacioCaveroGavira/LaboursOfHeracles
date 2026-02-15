using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Serilog;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SerilogConsoleAppGenericHost
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Wellcome to Serilog Examples!");

            var methods = GetMethodsDictionary();

            ShowExamples(methods);
            Console.Write("Selected example: ");
            var lineRead = Console.ReadLine();
            int exampleSelected = 0;

            do
            {
                bool isValidExampleNumber = !(lineRead == null || !int.TryParse(lineRead, out exampleSelected) || exampleSelected < 1 || exampleSelected > methods.Count);

                while (!isValidExampleNumber && exampleSelected != 0)
                {
                    Console.Write("Select a valid number: ");
                    lineRead = Console.ReadLine();
                    int.TryParse(lineRead, out exampleSelected);
                }

                if (isValidExampleNumber)
                {
                    Console.WriteLine($"------------------------ Example {exampleSelected} ------------------------");
                    methods[exampleSelected].Invoke(null, null);
                    Console.WriteLine($"--------------------------------------------------------------------------");
                    Console.WriteLine();

                    ShowExamples(methods);
                    Console.Write("Selected example: ");
                    lineRead = Console.ReadLine();
                }

            } while (exampleSelected != 0);

            Console.WriteLine("Bye!");
        }

        public static string FormatExampleName(string source)
        {
            source = source.Replace("Host", "");
            return String.Join(" ", Regex.Split(source, @"(?<!^)(?=[A-Z])"));
        }

        public static Dictionary<int, MethodInfo> GetMethodsDictionary()
        {
            var methods = new Dictionary<int, MethodInfo>();

            var methodInfos = typeof(HostExamples).GetMethods();
            int methodsCount = 0;
            foreach (var methodInfo in methodInfos)
            {
                if (methodInfo.Name.Contains("Host"))
                {
                    methodsCount++;
                    methods.Add(methodsCount, methodInfo);
                }
            }
            return methods;
        }

        public static void ShowExamples(Dictionary<int, MethodInfo> methods)
        {
            Console.WriteLine("Select a Serilog example to run");
            foreach (var methodInfo in methods)
            {
                Console.WriteLine($"{methodInfo.Key}. {FormatExampleName(methodInfo.Value.Name)}");
            }
            Console.WriteLine("0. Exit");
            Console.WriteLine();
        }

    }

}
