using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MASIN
{
    internal class Car:Vehicle
    {
        public string Brand;
        
        public string Model;
        
        public int MaxSpeed {  get; set; } 

        public Car(string Brand, string Model,int Year):base(Year)
        {
            this.Brand = Brand;
            this.Model = Model;
        }
        

        public override void ShowInfo()
        {
            Console.WriteLine($"this is {Year} {Brand} {Model} car");
        }
    }
}
