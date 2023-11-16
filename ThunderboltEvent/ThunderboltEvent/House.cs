namespace ThunderboltEvent
{
    public class House : ThunderboltEventObject
    {
        private event EventHandler<EventArgs> _blackoutEventHandler;

        public House()
        {
        }

        public void AddHomeAppliance(IHomAppliance appliance)
        {
            _blackoutEventHandler += appliance.OnBlackoutEvent;
        }

        public override void OnThunderboltEvent(object sender, EventArgs e)
        {
            WeatherEvent.ThunderboltEventHandler -= OnThunderboltEvent;
            Program.ConsoleWrite("천둥벼락이 떨어져 집은 정전이 되었다.");
            _blackoutEventHandler?.Invoke(sender, e);
        }
    }
}
