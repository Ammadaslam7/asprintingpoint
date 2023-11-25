using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPP.Core
{
    public class OrderItem
    {
        public int ID { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public float Price { get; set; }

        public OrderItem(int iD, Product product, int quantity, float price)
        {
            ID = iD;
            Product = product;
            Quantity = quantity;
            Price = price;
        }

        public OrderItem(Product product, int qty, float price) : this(-1, product, qty, price) { }

        public float TotalPrice
        {
            get
            {
                return Quantity * Price;
            }
        }
    }
}
