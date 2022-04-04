using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace custom_cms_code.LogicLayer
{
    class User
    {
        
        public static string Name;
        private string Pass;

        public User(string name, string pass)
        {
            Name = name;
            Pass = pass;
        }

        public string GetName()
        {
            return Name;
        }
    }
}
