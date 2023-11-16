namespace ThunderboltEvent
{
    public class ThunderboltEventArgs : EventArgs
    {
        public int Volume { get; init; }
        public ThunderboltEventArgs()
        {
            Random random = new Random();
            Volume = random.Next(1, 11);
        }
    }
}
