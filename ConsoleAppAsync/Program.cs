using ConsoleAppAsync.Async;
using ConsoleAppAsync.Sync;

namespace ConsoleAppAsync
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            ISomeClass syncTask1 = new SomeClass1();
            string textSyncTask1 = syncTask1.ToString();

            ISomeClass syncTask2 = new SomeClass2();
            string textSyncTask2= syncTask1.ToString();


            IAsyncTask asyncTask1 = new Class1();
            IAsyncTask asyncTask2 = new Class2();

            Console.WriteLine("end, World!");
        }
    }
}
