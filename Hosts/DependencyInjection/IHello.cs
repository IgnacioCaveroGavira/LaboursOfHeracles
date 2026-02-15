namespace DependencyInjection
{
    public interface IHello
    {
        string Name { get; set; }

        void SayHello();
    }
}