using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace custom_cms_code.LogicLayer
{
    class GlobalVars
    {
        public static DataTable Users { get; }
        public static DataTable Websites { get; }
        private static string sqlCon = "Server=(localdb)\\MSSQLLocalDB;Integrated Security=true;Database=custom_cms";

        public static string getSqlCon()
        {
            return sqlCon;
        }
    }
}
