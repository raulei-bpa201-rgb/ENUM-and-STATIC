namespace MASIN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car main = new Car("Toyota","camry",2013);

            Bus bus = new Bus(2003);

            bus.PassengerCount = 44;

            bus.ShowInfo();
            main.ShowInfo();
        }
    }
}
