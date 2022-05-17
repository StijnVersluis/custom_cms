using Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    class UserDAL
    {
        public static DataTable Users;

        public UserDAL()
        {
            Users = GlobalFuncs.SelectQueryFrom("users");
        }

        public List<UserDTO> GetAll()
        {
            List<UserDTO> users = new List<UserDTO>();

            string connectionString = GlobalVars.connectionString;

            //using (SqlConnection con = new SqlConnection(connectionString))
            //{
            //    con.Open();
            //    using (SqlCommand sqlCommand = new SqlCommand("SELECT + FROM Users"))
            //    {
            //        SqlDataReader reader = sqlCommand.ExecuteReader();
            //        while (reader.Read())
            //        {
            //            MessageBox.Show((string)reader["Location"]);

            //            users.Add(new UserDTO((int)reader["Id"], (int)reader["Website_id"], (string)reader["Location"]));
            //        }
            //    }
            //}

            return users;
        }
    }
}
