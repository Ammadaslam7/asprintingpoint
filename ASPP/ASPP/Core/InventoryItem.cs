using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPP.Core
{
    internal class InventoryItem
    {
        public Product Product { get; set; }
        public int Stock { get; set; }
        public int RestockThreshold { get; set; }

        public InventoryItem(Product product, int stock, int restockThreshold)
        {
            Product = product;
            Stock = stock;
            RestockThreshold = restockThreshold;
        }
    }
}
