using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogic
{
    class User
    {
        public int Id { private set; get; }
        public string Name { private set; get; }
        private string Pass;

        public User(int id, string name, string pass)
        {
            Id = id;
            Name = name;
            Pass = pass;
        }
    }
}
