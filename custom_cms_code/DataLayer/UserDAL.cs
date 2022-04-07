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



            return users;
        }
    }
}
