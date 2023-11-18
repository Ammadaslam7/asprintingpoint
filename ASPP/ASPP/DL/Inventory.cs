using ASPP.Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPP.DL
{
    internal class Inventory
    {
        public static void addItem(Product product, int stock, int threshold)
        {
            SQLHelper.runStatement("INSERT INTO Inventory (ProductID, Stock, RestockThreshold) VALUES (@Product, @Stock, @Threshold)", new Dictionary<string, object>()
            {
                { "@Product", product?.ID },
                { "@Stock", stock },
                { "@Threshold", threshold },
            });
        }

        public static InventoryItem getItem(Product product)
        {
            InventoryItem item = null;
            DataTable items = SQLHelper.runQuery("SELECT Stock, RestockThreshold FROM Inventory WHERE ProductID = @Product", new Dictionary<string, object>()
            {
                { "Product", product?.ID }
            });

            if (items.Rows.Count > 0)
                item = new InventoryItem(product, Convert.ToInt32(items.Rows[0][0]), Convert.ToInt32(items.Rows[0][1]));

            return item;
        }

        public static bool itemExists(Product product) => getItem(product) != null;

        public static bool updateItem(Product product, int stock, int threshold)
        {
            return SQLHelper.runStatement("UPDATE INTO Inventory SET Stock = @Stock, RestockThresold = @Thresold WHERE ProductID = @Product", new Dictionary<string, object>()
            {
                { "@Product", product?.ID },
                { "@Stock", stock },
                { "@Threshold", threshold },
            }) > 0;
        }
    }
}
