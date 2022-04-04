using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace custom_cms_code.DataLayer
{
    class GlobalFuncs
    {
        public static string test = "hello";
        public static DataTable SelectQueryFrom(string tableName)
        {
            string conStr = "SELECT * FROM dbo." + tableName;
            DataTable dt;

            using (SqlConnection connection = new SqlConnection(custom_cms_code.LogicLayer.GlobalVars.getSqlCon()))
            {
                connection.Open();
                SqlDataAdapter da = new SqlDataAdapter();
                SqlCommand command = new SqlCommand(conStr, connection);

                da.SelectCommand = command;

                DataSet ds = new DataSet();
                da.Fill(ds);

                dt = ds.Tables[0];

                connection.Close();
            }
            return dt;
        }

        public static DataTable SelectQueryFrom(string tableName, string whereClauseName, string whereClauseValue)
        {
            string conStr = "SELECT * FROM dbo." + tableName + " WHERE @" + whereClauseName + " = " + whereClauseValue;
            DataTable dt;

            using (SqlConnection connection = new SqlConnection(GlobalVars.getSqlCon()))
            {
                connection.Open();
                SqlDataAdapter da = new SqlDataAdapter();
                SqlCommand command = new SqlCommand(conStr, connection);

                da.InsertCommand.Parameters.AddWithValue("@" + whereClauseName, whereClauseValue);
                da.SelectCommand = command;

                DataSet ds = new DataSet();
                da.Fill(ds);

                dt = ds.Tables[0];

                connection.Close();
            }
            return dt;
        }

    }
}
