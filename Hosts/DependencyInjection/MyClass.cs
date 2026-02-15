namespace DependencyInjection
{
    public class MyClass : IHello, IAge
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public MyClass(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void SayHello()
        {
            Console.WriteLine($"Hello, I'm {Name}");
        }

        public void SayMyAge()
        {
            Console.WriteLine($"My age is {Age}");
        }
    }
}
