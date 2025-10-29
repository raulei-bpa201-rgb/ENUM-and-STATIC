using System.Security.Cryptography.X509Certificates;

namespace Enum
{
    public enum OrderStatus
    {
        Pending=1,
        Processing=2,
        Shipped=3,
        Delivered=4,
        Cancelled=5
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order { CustomerName = "raul",
                Id = 345, Status = (int)OrderStatus.Cancelled };

            OrderStatus zakaz = OrderStatus.Pending;

            order.DisplayStatusMessage((int)zakaz);
        }
    }
}
