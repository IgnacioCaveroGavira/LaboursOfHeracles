namespace DependencyInjection
{
    public class HelloService
    {
        private readonly IHello _myClass;

        public HelloService(IHello myClass)
        {
            _myClass = myClass;
        }

        public void SayInfo()
        {
            _myClass.SayHello();
            Console.WriteLine();
        }
    }
}
