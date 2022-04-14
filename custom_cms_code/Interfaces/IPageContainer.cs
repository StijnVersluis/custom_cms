using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public interface IPageContainer
    {
        public List<PageDTO> GetAll();
        public PageDTO FindById(int id);
    }
}
