using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendMessage
{
    

    public class SmsSender:MessageSender
    {
        public static void SendMessage() 
        {
            Console.WriteLine("SMS send");
        }
    }
}
