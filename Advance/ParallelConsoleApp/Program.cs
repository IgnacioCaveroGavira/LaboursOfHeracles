using System.ComponentModel;
using System.Diagnostics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ParallelConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start Parallel Testing!");

            var data = CreateDummyData(100);
            
            NormalFor(data);
            ParallelForWithOptions(data, 2);
            ParallelFor(data);

            Console.WriteLine("Bye, Parallel Testing!");
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
            Console.WriteLine("Elapsed time to create data: " + stopwatch.Elapsed);
            Console.WriteLine();

            return result;
        }


        static void NormalFor(List<DummyData> data)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            foreach (var item in data)
            {
                LongProcess(item);
            }
            stopwatch.Stop();
            Console.WriteLine("Elapsed time Normal For: " + stopwatch.Elapsed);
            Console.WriteLine();
        }

        static void ParallelFor(List<DummyData> data)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            Parallel.ForEach(data, item => {
                LongProcess(item);
            });

            stopwatch.Stop();
            Console.WriteLine("Elapsed time Parallel For (self-managed): " + stopwatch.Elapsed);
            Console.WriteLine();
        }

        static void ParallelForWithOptions(List<DummyData> data, int degreeOfParallelism)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            var parallelOptions = new ParallelOptions() { MaxDegreeOfParallelism = degreeOfParallelism };

            Parallel.ForEach(data, parallelOptions, item => {
                LongProcess(item);
            });

            stopwatch.Stop();
            Console.WriteLine($"Elapsed time Parallel For (MaxDegreeOfParallelism: {degreeOfParallelism}): " + stopwatch.Elapsed);
            Console.WriteLine();
        }

    }
}
