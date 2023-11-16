namespace ThunderboltEvent
{
    public static class WeatherEvent
    {
        public static event EventHandler ThunderboltEventHandler;

        public static void OnThunderboltEventTrigger()
        {
            var args = new ThunderboltEventArgs();
            Console.WriteLine("******************************************************************");
            Program.ConsoleWrite("갑작스럽게 천둥벼락이 친다.");
            Program.ConsoleWrite($"Volume : {args.Volume}");
            Console.WriteLine("******************************************************************");
            ThunderboltEventHandler?.Invoke(null, args);
        }
    }
}
