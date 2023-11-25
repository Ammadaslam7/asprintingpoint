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
        private static SqlCommand prepareCommand(string cmdText, Dictionary<string, object> paramters = null)
        {
            SqlCommand cmd = DBHandler.getInstance().getConnection().CreateCommand();
            cmd.CommandText = cmdText;

            if (paramters != null)
                foreach (KeyValuePair<string, object> param in paramters)
                {
                    cmd.Parameters.AddWithValue(param.Key, param.Value);
                }

            return cmd;
        }

        public static int runStatement(string cmdText, Dictionary<string, object> paramters = null) =>
            prepareCommand(cmdText, paramters).ExecuteNonQuery();

        public static DataTable runQuery(string cmdText, Dictionary<string, object> paramters = null)
        {
            SqlCommand cmd = prepareCommand(cmdText, paramters);

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            return dt;
        }

        public static int runScalarStatement(string cmdText, Dictionary<string, object> paramters = null)
        {
            object obj = prepareCommand(cmdText, paramters).ExecuteScalar();
            return obj == DBNull.Value ? -1 : (int)obj;
        }
    }
}
