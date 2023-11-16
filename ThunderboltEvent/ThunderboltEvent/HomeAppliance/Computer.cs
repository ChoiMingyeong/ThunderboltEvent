namespace ThunderboltEvent
{
    public class Computer : ThunderboltEventObject, IHomAppliance
    {
        public Computer()
        {
        }

        public bool Power { get; set; } = true;

        public void OnBlackoutEvent(object sender, EventArgs e)
        {
            if (Power)
            {
                Power = false;
                Program.ConsoleWrite("컴퓨터는 정전이 되어 꺼졌다.");
            }
        }
        public override void OnThunderboltEvent(object sender, EventArgs e)
        {
            if (Power)
            {
                Program.ConsoleWrite($"천둥벼락으로 인해 인터넷이 나갔다.");
            }
        }
    }
}