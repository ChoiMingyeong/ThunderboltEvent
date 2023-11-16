using ThunderboltEvent;

class Program
{
    public static void Main(string[] args)
    {
        House house = new House();
        TV tv = new TV();
        Computer computer = new Computer();
        house.AddHomeAppliance(tv);
        house.AddHomeAppliance(computer);

        Person person1 = new Person("김철수", 32);
        Person person2 = new Person("박영희", 30);
        Dog dog1 = new Dog("별님이");

        while (true)
        {
            if (Console.ReadKey().Key.Equals(ConsoleKey.F1))
            {
                WeatherEvent.OnThunderboltEventTrigger();
            }
        }
    }

    public static void ConsoleWrite(string str)
    {
        Console.WriteLine($"[{DateTime.Now}] {str}");
    }
}