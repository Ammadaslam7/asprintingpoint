using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASPP.Core;

namespace ASPP.DL
{
    internal class ProductDL
    {
        public static void addProduct(string name, string description, float price, uint stock, bool isPurchaseable, Category category)
        {
            SQLHelper.runStatement("INSERT INTO Product (Name, Description, Price, Stock, PurchaseAble, CategoryID) VALUES (@Name, @Desc, @Price, @Stock, @Purchase, @Cate)", new Dictionary<string, object>()
            {
                { "@Name", name },
                { "@Desc", description },
                { "@Price", price },
                { "@Stock", stock },
                { "@Purchase", isPurchaseable },
                { "@Cate", category?.ID },
            });
        }

        public static List<Product> getProducts()
        {
            DataTable productTbl = SQLHelper.runQuery("SELECT ProductID, Name, Description, Price, Stock, PurchaseAble, CategoryID FROM Product");
            List<Product> products = new List<Product>(productTbl.Rows.Count);

            foreach (DataRow row in productTbl.Rows)
            {
                products.Add(new Product(Convert.ToInt32(row[0]), Convert.ToString(row[1]), Convert.ToString(row[2]), (float)Convert.ToDouble(row[3]), Convert.ToUInt32(row[4]), Convert.ToBoolean(row[5]), (Category)row[6]));
            }

            return products;
        }

        public static Product getProduct(int ID)
        {
            DataTable productTbl = SQLHelper.runQuery("SELECT ProductID, Name, Description, Price, Stock, PurchaseAble, CategoryID FROM Product WHERE ProductID = @ID",
                new Dictionary<string, object>()
                {
                    { "@ID", ID },
                });
            Product product = null;

            if (productTbl.Rows.Count > 0)
            {
                DataRow row = productTbl.Rows[0];
                product = new Product(Convert.ToInt32(row[0]), Convert.ToString(row[1]), Convert.ToString(row[2]), (float)Convert.ToDouble(row[3]), Convert.ToUInt32(row[4]), Convert.ToBoolean(row[5]), CategoryDL.getCategory((int)row[6]));
            }

            return product;
        }

        public static bool updateProduct(int ID, string name, string description, float price, uint stock, bool isPurchaseable, Category category)
        {
            return SQLHelper.runStatement("UPDATE Product SET Name = @Name, Description = @Desc, Price = @Price, Stock = @Stock, PurchaseAble = @Purchase, CategoryID = @Cate WHERE ProductID = @ID", new Dictionary<string, object>()
            {
                { "@ID", ID },
                { "@Name", name },
                { "@Desc", description },
                { "@Price", price },
                { "@Stock", stock },
                { "@Purchase", isPurchaseable },
                { "@Cate", category?.ID },
            }) > 0;
        }

        public static bool delProdut(int ID)
        {
            return SQLHelper.runStatement("DELETE FROM Product WHERE ProductID = @ID", new Dictionary<string, object>()
            {
                { "@ID", ID },
            }) > 0;
        }
    }
}
