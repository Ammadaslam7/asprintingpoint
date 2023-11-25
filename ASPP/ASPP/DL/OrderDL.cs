using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASPP.Core;

namespace ASPP.DL
{
    public class OrderDL
    {
        public static void addOrder(DateTime orderDate, OrderStatus status, List<OrderItem> items)
        {
            int ID = SQLHelper.runScalarStatement("INSERT INTO Order (UserID, OrderDate, Status) OUTPUT INSERTED.OrderID VALUE (@User, @Date, @Status)", new Dictionary<string, object>
            {
                { "@User" , 1},
                { "@Date", orderDate.Date },
                { "@Status", status }
            });

            Order order = new Order(ID, orderDate, status, items);

            foreach(OrderItem item in items)
            {
                addOrderItem(order, item);
            }
        }

        public static void addOrderItem(Order order, Product product, int qty, float price)
        {
            SQLHelper.runStatement("INSERT INTO OrderItem (OrderID, ProductID, Quantity, UnitPrice) VALUE (@Order, @Product, @Qty, @Price)", new Dictionary<string, object>
            {
                {"@Order", order?.ID },
                {"@Product", product?.ID },
                {"@Qty", qty },
                {"@Price", price }
            });
        }

        public static void addOrderItem(Order order, OrderItem item) => addOrderItem(order, item.Product, item.Quantity, item.Price);
    }
}
