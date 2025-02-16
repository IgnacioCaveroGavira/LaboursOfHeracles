namespace ConsoleAppAsync.Sync
{
    public class SomeClass1 : ISomeClass
    {
        public string DoSomething()
        {
            Thread.Sleep(2000);
            string text = "Sync Task 1 end";
            Console.WriteLine(text);
            return text;
        }
    }

    public class SomeClass2 : ISomeClass
    {
        public string DoSomething()
        {
            Thread.Sleep(4000);
            string text = "Sync Task 2 end";
            Console.WriteLine(text);
            return text;
        }
    }
}
