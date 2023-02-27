namespace Uebung02
{
    internal class StringList
    {
        private int size;

        public int Size
        {
            get => size;
            set
            {
                size = value;
                this.Data = new string[value];
            }
        }
        public string[] Data { get; set; }

        public StringList()
        {
            this.Data = new string[0];
        }

        public string this[int index]
        {
            get => this.Data[index % this.Size];
            set => this.Data[index % this.Size] = value;
        }
    }
}
