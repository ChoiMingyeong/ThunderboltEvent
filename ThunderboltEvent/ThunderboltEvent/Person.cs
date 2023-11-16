namespace ThunderboltEvent
{
    public class Person : ThunderboltEventObject
    {
        public string Name { get; init; }
        public int Age { get; init; }
        public DateTime SurpriseCoolTime { get; set; } = DateTime.MinValue;
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public override void OnThunderboltEvent(object sender, EventArgs e)
        {
            DateTime now = DateTime.UtcNow;
            if (now.Subtract(SurpriseCoolTime).TotalSeconds > 10)
            {
                SurpriseCoolTime = now;
                Program.ConsoleWrite($"{Name}({Age})은/는 천둥 소리에 깜짝 놀란다.");

                if (e is not ThunderboltEventArgs thunderboltEventArgs)
                {
                    return;
                }

                Random rand = new Random();
                int survive = rand.Next(1, 11);
                Program.ConsoleWrite($"{Name} Survive : {survive}");
                if (survive <= thunderboltEventArgs.Volume)
                {
                    WeatherEvent.ThunderboltEventHandler -= OnThunderboltEvent;
                    Program.ConsoleWrite($"{Name}({Age})은/는 심장마비로 사망하였다.");
                }
            }
        }
    }
}
