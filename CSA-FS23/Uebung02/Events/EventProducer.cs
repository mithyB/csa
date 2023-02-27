namespace Uebung02.Events
{
    internal class EventProducer
    {
        // Event deklarieren
        public event MyEventHandler MyEvent;

        // Event "feuern"
        public void OnMyEvent(string data)
        {
            if (MyEvent != null)
                MyEvent(this, new MyEventArgs(data));
        }
    }
}
