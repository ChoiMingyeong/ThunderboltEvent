namespace ThunderboltEvent
{
    public interface IHomAppliance
    {
        public abstract bool Power { get; set; }
        public abstract void OnBlackoutEvent(object sender, EventArgs e);
    }
}