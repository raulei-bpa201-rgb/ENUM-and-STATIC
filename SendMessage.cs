using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendMessage
{
    public abstract class MessageSender
    {
        public void SendMessage() { }

        public static void Quit(int choose)
        {
            switch (choose)
            {
                case 1:
                    EmailSender.SendMessage();
                    break;
                case 2:
                    SmsSender.SendMessage();
                    break;
                default:
                    Console.WriteLine("hec ne gonderilmedi");
                    break;
            }
        }
    }
}
