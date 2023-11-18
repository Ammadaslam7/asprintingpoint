using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASPP.Core;

namespace ASPP.DL
{
    internal class CategoryDL
    {
        public static void addCategory(string name)
        {
            SQLHelper.runStatement("INSERT INTO Category (Name) VALUES (@Name)", new Dictionary<string, object>()
            {
                { "@Name", name },
            });
        }

        public static List<Category> getCategories()
        {
            DataTable categoryTbl = SQLHelper.runQuery("SELECT CategoryID, Name FROM Category");
            List<Category> categories = new List<Category>(categoryTbl.Rows.Count);

            foreach (DataRow row in categoryTbl.Rows)
            {
                categories.Add(new Category(Convert.ToInt32(row[0]), Convert.ToString(row[1])));
            }

            return categories;
        }

        public static Category getCategory(int ID)
        {
            DataTable categoryTbl = SQLHelper.runQuery("SELECT CategoryID, Name FROM Category WHERE CategoryID = @ID",
                new Dictionary<string, object>()
                {
                    { "@ID", ID },
                });
            Category category = null;

            if (categoryTbl.Rows.Count > 0)
            {
                DataRow row = categoryTbl.Rows[0];
                category = new Category(Convert.ToInt32(row[0]), Convert.ToString(row[1]));
            }

            return category;
        }

        public static bool updateCategory(int ID, string name, string description, float price, uint stock, bool isPurchaseable, Category category)
        {
            return SQLHelper.runStatement("UPDATE Category SET Name = @Name WHERE CategoryID = @ID", new Dictionary<string, object>()
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
            return SQLHelper.runStatement("DELETE FROM Category WHERE CategoryID = @ID", new Dictionary<string, object>()
            {
                { "@ID", ID },
            }) > 0;
        }
    }
}
