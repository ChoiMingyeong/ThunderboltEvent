namespace ThunderboltEvent
{
    public abstract class ThunderboltEventObject
    {
        public ThunderboltEventObject()
        {
            WeatherEvent.ThunderboltEventHandler += OnThunderboltEvent;
        }

        public abstract void OnThunderboltEvent(object sender, EventArgs e);
    }
}
