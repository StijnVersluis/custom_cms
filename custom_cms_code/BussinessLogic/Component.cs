using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace LogicLayer
{
    public class Component
    {
        public int Id { private set; get; }
        public int ComponentId;
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
        public Component(int id, int componentId, string name, string html, bool is_shown)
        {
            Id = id;
            ComponentId = componentId;
            Name = name;
            Html = html;
            Is_shown = is_shown;
        }
        public Component(ComponentDTO dTO)
        {
            Id = dTO.Id;
            ComponentId = dTO.ComponentId;
            Name = dTO.Name;
            Html = dTO.Html;
            Is_shown = dTO.Is_shown;
        }
    }
}
