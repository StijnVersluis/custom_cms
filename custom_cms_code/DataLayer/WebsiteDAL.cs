using Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer
{
    public class WebsiteDAL : IWebsite, IWebsiteContainer
    {
        public WebsiteDTO FindById(int id)
        {
            throw new NotImplementedException();
        }

        public List<WebsiteDTO> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<PageDTO> GetAllPagesFromWebsiteId(int id)
        {
            throw new NotImplementedException();
        }

        public List<PageDTO> GetPages()
        {
            throw new NotImplementedException();
        }
    }
}
