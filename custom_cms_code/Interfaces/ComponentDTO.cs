using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class ComponentDTO
    {
        public int Id;
        public string Name;
        public string Html;
        public bool Is_shown;

        public ComponentDTO(int id, string name, string html, bool is_shown)
        {
            Id = id;
            Name = name;
            Html = html;
            Is_shown = is_shown;
        }
    }
}
