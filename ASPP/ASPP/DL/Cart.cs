using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASPP.Core;

namespace ASPP.DL
{
    public class Cart
    {
        static Order _order = new Order();

        public static void newCart() => _order = new Order();

        public static void addItem(Product product, int qty)
        {
            if (!_order.alreadyHas(product))
                _order.addItem(product, qty);
            else
                _order.getItem(product).Quantity += qty;
        }

        public static ReadOnlyCollection<OrderItem> getItems() => _order.Items.AsReadOnly();

        public static void removeItem(Product product) => _order.removeItem(product);
        public static float TotalBill => _order.Bill;
    }
}
