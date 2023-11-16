namespace ThunderboltEvent
{
    public interface IHomeAppliance
    {
        public abstract bool Power { get; set; }
        public abstract void OnBlackoutEvent(object sender, EventArgs e);
    }
}