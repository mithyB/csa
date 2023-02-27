namespace Uebung02.Events
{
    internal class EventConsumer
    {
        public EventConsumer(EventProducer eventProducer)
        {
            eventProducer.MyEvent += this.EventProducer_MyEvent;
        }

        private void EventProducer_MyEvent(object sender, MyEventArgs e)
        {
            Console.WriteLine("EventProducer_MyEvent:" + e.EventData);
        }
    }
}
