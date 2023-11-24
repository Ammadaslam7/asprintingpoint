using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPP.Core
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public uint Stock { get; set; }
        public bool IsPurchaseable { get; set; }
        public Category Category { get; set; }

        public Product(int Id, string name, string description, float price, uint stock, bool isPurchaseable, Category category)
        {
            ID = Id;
            Name = name;
            Description = description;
            Price = price;
            Stock = stock;
            IsPurchaseable = isPurchaseable;
            Category = category;
        }

        public Product(string name, string description, float price, uint stock, bool isPurchaseable, Category category) : this(-1, name, description, price, stock, isPurchaseable, category) {}
    }
}
