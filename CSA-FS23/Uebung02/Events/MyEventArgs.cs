namespace Uebung02.Events
{
    internal class MyEventArgs : EventArgs
    {
        public string EventData { get; set; }

        public MyEventArgs(string eventData)
        {
            this.EventData = eventData;
        }
    }
}
