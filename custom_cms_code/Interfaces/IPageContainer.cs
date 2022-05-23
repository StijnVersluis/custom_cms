using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public interface IPageContainer
    {
        public List<PageDTO> GetAll(int websiteId);
        public PageDTO FindById(int id);
        public void CreatePage(PageDTO page);
        public void EditPage(PageDTO page);
        public void DeletePage(int id);
    }
}
