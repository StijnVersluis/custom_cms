using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    public class ComponentContainer
    {
        private IComponentContainer IComponentContainer;
        public ComponentContainer(IComponentContainer cont)
        {
            IComponentContainer = cont;
        }

        public List<Component> GetAll(int pageId)
        {

            var res = new List<Component>();
            IComponentContainer.GetAllFromPage(pageId).ForEach(w =>
            {
                res.Add(new Component(w));
            });
            return res;
        }
    }
}
