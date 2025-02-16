using System.Reflection.Metadata.Ecma335;

namespace ConsoleAppAsync.Async
{
    public class Class1 : IAsyncTask
    {
        public async Task DoSomething()
        {
            await Task.Delay(2000);
            Console.WriteLine("Async Task Parameterized 2 end");
        }
    }

    public class Class2 : IAsyncTask
    {
        public async Task DoSomething()
        {
            await Task.Delay(4000);
            Console.WriteLine("Async Task Parameterized 2 end");
        }
    }
}
