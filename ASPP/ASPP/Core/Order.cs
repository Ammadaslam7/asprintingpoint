using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPP.Core
{
    public enum OrderStatus
    {
        Processing,
        InTransit,
        Delivered,
        Unknown
    }

    public class Order
    {
        public int ID { get; set; }
        public DateTime OrderDate { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> Items { get; set; }

        public Order(int iD, DateTime orderDate, OrderStatus status, List<OrderItem> items)
        {
            ID = iD;
            OrderDate = orderDate;
            Status = status;
            Items = items ?? new List<OrderItem>();
        }

        public Order(DateTime orderDate, OrderStatus status, List<OrderItem> items) : this(-1, orderDate, status, items) { }
        public Order() : this(DateTime.Now.Date, OrderStatus.Unknown, null) { }

        public OrderItem getItem(Product product) => product.ID == -1 ? null : Items.FirstOrDefault(o => o.Product.ID == product.ID);

        public bool alreadyHas(Product product) => getItem(product) != null;

        public void addItem(OrderItem item) => Items.Add(item);
        public void addItem(Product product, int qty, float price) => addItem(new OrderItem(product, qty, price));
        public void addItem(Product product, int qty) => addItem(product, qty, product.Price);

        public void removeItem(Product product) => Items.RemoveAll(o => o.Product.ID == product.ID);

        public float Bill
        {
            get
            {
                float total = 0;

                foreach(var item in Items)
                {
                    total += item.TotalPrice;
                }

                return total;
            }
        }
    }
}
