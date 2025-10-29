using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MASIN
{
    public abstract class Vehicle
    {
        public string Color { get; set; }

        public int Year;

        public Vehicle(int Year) 
        {
            this.Year = Year;
        }

        public abstract void ShowInfo();
    }
}
