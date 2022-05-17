using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IComponentContainer
    {
        public List<ComponentDTO> GetAllFromPage(int pageId);
        public ComponentDTO FindById(int id);
    }
}
