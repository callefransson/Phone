namespace PhoneInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Phone iPhone = new Phone();
            iPhone.Introduce();
            Phone samsung = new Phone("Samsung", "Galaxy Z flip5");
            samsung.Introduce();
            Phone nokia = new Phone("Nokia", "nokia 3310", "1 September 2000");
            nokia.Introduce();
        }
    }
}