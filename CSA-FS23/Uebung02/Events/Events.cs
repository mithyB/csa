namespace Uebung02.Events
{
    internal class Events
    {
        public Events()
        {
            var producer = new EventProducer();
            var consumer1 = new EventConsumer(producer);
            var consumer2 = new EventConsumer(producer);
            producer.OnMyEvent("Event fired...");
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            var prog = new Events();
            Console.Read();
        }
    }
}
