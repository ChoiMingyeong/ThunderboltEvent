namespace ThunderboltEvent
{
    public enum EState
    {
        Idle,
        Blackout,
    }

    public class House : ThunderboltEventObject
    {
        private event EventHandler<EventArgs> _blackoutEventHandler;
        private EState _state = EState.Idle;

        public House()
        {
        }

        public void AddHomeAppliance(IHomAppliance appliance)
        {
            _blackoutEventHandler += appliance.OnBlackoutEvent;
        }

        public override void OnThunderboltEvent(object sender, EventArgs e)
        {
            if (_state != EState.Blackout)
            {
                _state = EState.Blackout;
                Program.ConsoleWrite("천둥벼락이 떨어져 집은 정전이 되었다.");
                _blackoutEventHandler?.Invoke(sender, e);
            }
        }
    }
}
