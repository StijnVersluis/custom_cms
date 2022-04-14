using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public interface IWebsiteContainer
    {
        public List<WebsiteDTO> GetAll();
        public List<PageDTO> GetAllPagesFromWebsiteId(int id);
        public WebsiteDTO FindById(int id);
    }
}
