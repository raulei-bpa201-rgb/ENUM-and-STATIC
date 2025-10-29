using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MASIN
{
    internal class Bus:Vehicle
    {
        public int PassengerCount {  get; set; }

        public Bus(int Year):base(Year) {}

        public override void ShowInfo()
        {
            Console.WriteLine($"this bus's Passenger count is {PassengerCount}");
        }
    }
}
