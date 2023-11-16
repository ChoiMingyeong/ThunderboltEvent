namespace ThunderboltEvent
{
    public class TV : IHomAppliance
    {
        public bool Power { get; set; } = false;

        public void OnBlackoutEvent(object sender, EventArgs e)
        {
            if (Power)
            {
                Power = false;
                Program.ConsoleWrite($"TV는 정전이 되어 꺼졌다.");
            }
        }
    }
}