namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var A = new ClassA("A");
            var B0 = new ClassB();
            var B1 = new ClassB("B1");
            var B2 = new ClassB("B2", 2);

            var AA = new ClassA("AA");
            var AB = new ClassB("AB");

        }
    }
}