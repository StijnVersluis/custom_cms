using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace LogicLayer
{
    class Component
    {
        private int Id;
        public string Name;
        public string Html;
        public bool Is_shown;

        public Component(int id, string name, string html, bool is_shown)
        {
            Id = id;
            Name = name;
            Html = html;
            Is_shown = is_shown;
        }
        public Component(ComponentDTO dTO)
        {
            Id = dTO.Id;
            Name = dTO.Name;
            Html = dTO.Html;
            Is_shown = dTO.Is_shown;
        }
    }
}
