namespace ThunderboltEvent
{
    public class Dog : ThunderboltEventObject
    {
        public string Name { get; init; }

        public Dog(string name)
        {
            Name = name;
        }

        public override void OnThunderboltEvent(object sender, EventArgs e)
        {
            if (e is not ThunderboltEventArgs thunderboltEventArgs)
            {
                return;
            }

            if (thunderboltEventArgs.Volume > 5)
            {
                Program.ConsoleWrite($"천둥벼락에 놀란 {Name}은/는 컹컹 짖는다.");
            }
        }
    }
}
