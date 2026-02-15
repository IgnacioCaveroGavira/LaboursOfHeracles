namespace DependencyInjection
{
    public class MyClassService
    {
        private readonly MyClass _myClass;

        public MyClassService(MyClass myClass)
        {
            _myClass = myClass;
        }

        public void SayInfo()
        {
            _myClass.SayHello();
            _myClass.SayMyAge();
            Console.WriteLine();
        }
    }
}
