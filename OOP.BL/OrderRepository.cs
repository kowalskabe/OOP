using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.BL
{
    class OrderRepository
    {
        public Order Retrieve(int orderId)
        {
            Order order = new Order(orderId);

            //tmp
            if (orderId == 10)
            {
                order.OrderDate = new DateTimeOffset(DateTime.Now.Year, 6, 21, 12, 00, 00, new TimeSpan(7, 0, 0));
            }

            return order;
        }

        public bool Save(Order order)
        {
            return true;
        }
    }
}
