using ASPP.Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPP.DL
{
    internal class SQLHelper
    {
        public static int runStatement(string cmdText, Dictionary<string, object> paramters = null)
        {
            SqlCommand cmd = DBHandler.getInstance().getConnection().CreateCommand();
            cmd.CommandText = cmdText;

            if (paramters != null)
                foreach(KeyValuePair<string, object> param in paramters)
                {
                    cmd.Parameters.AddWithValue(param.Key, param.Value);
                }

            return cmd.ExecuteNonQuery();
        }

        public static DataTable runQuery(string cmdText, Dictionary<string, object> paramters = null)
        {
            SqlCommand cmd = DBHandler.getInstance().getConnection().CreateCommand();
            cmd.CommandText = cmdText;

            if (paramters != null)
                foreach (KeyValuePair<string, object> param in paramters)
                {
                    cmd.Parameters.AddWithValue(param.Key, param.Value);
                }

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            return dt;
        }
    }
}
