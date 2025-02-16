using System.Reflection.Metadata.Ecma335;

namespace ConsoleAppAsync.Async
{
    public class ClassParametter1 : IAsyncTaskParameterized
    {
        public async Task<string> DoSomething()
        {
            await Task.Delay(2000);
            return "Async Task Parameterized 1 end";
        }
    }

    public class ClassParametter2 : IAsyncTaskParameterized
    {
        public async Task<string> DoSomething()
        {
            await Task.Delay(4000);
            return "Async Task Parameterized 2 end";
        }
    }
}
