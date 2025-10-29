using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    public class Order
    {
        public int Id {  get; set; }
        public string CustomerName {  get; set; }
        public int Status {  get; set; }
        public  void DisplayStatusMessage(int num)
        {
            switch (Status)
            {
                case 1:
                    Console.WriteLine("Sifariş qəbul olundu, emal gözləyir.");
                    break;
                case 2:
                    Console.WriteLine("Sifariş hazırda emal olunur.");
                    break;
                case 3:
                    Console.WriteLine("Sifariş göndərildi, yoldadır.");
                    break;
                case 4:
                    Console.WriteLine("Sifariş müştəriyə çatdı.");
                    break;
                case 5:
                    Console.WriteLine("Sifariş ləğv edildi.");
                    break;  
                default:
                    Console.WriteLine("give me order");
                    break;
            }
        }
    }
}
