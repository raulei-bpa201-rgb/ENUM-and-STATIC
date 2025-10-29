using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SendMessage
{
    public class EmailSender:MessageSender
    {
        public static void SendMessage()
        {
            Console.WriteLine("Email send");
        }
    }
}
