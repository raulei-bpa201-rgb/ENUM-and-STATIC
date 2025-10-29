namespace MASIN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car main = new Car("Toyota","camry",2013);

            Bus bus = new Bus(2003);

            bus.PassengerCount = 44;

            Bus bus_2 = new Bus(2103);

            bus_2.PassengerCount = 222;

            Car main_3 = new Car("BMW", "X7", 2025);

            Vehicle[] array = { main, main_3, bus_2, bus };
            foreach (var v in array)
            {
                v.ShowInfo();
            }
        }
    }
}
