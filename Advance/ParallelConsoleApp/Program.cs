using System.ComponentModel;
using System.Diagnostics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ParallelConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var data = CreateDummyData(1000000);
            test1(data);
            test2(data);         

            Console.WriteLine("Bye, World!");
        }

        static void LongProcess(DummyData dummyData)
        {
            Thread.Sleep(100);
            Console.WriteLine(dummyData);
        }

        static List<DummyData> CreateDummyData(int number = 500)
        {
            var result = new List<DummyData>();
            var random = new Random();

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < number; i++)
            {
                result.Add(new DummyData
                {
                    ID = i + 1,
                    Name = $"Person_{i + 1}",
                    Age = random.Next(14, 81)
                });
            }
            stopwatch.Stop();
            Console.WriteLine("Elapsed time: " + stopwatch.Elapsed);

            return result;
        }


        static void test1(List<DummyData> data)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            foreach (var item in data)
            {
                LongProcess(item);
            }
            stopwatch.Stop();
            Console.WriteLine("Elapsed time: " + stopwatch.Elapsed);
        }

        static void test2(List<DummyData> data)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            Parallel.ForEach(data, item => {
                LongProcess(item);
            });

            stopwatch.Stop();
            Console.WriteLine("Elapsed time: " + stopwatch.Elapsed);
        }
    }
}
