using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public interface IWebsite
    {
        public void UpdatePage(WebsiteDTO website);
        public void DeleteWebsite(WebsiteDTO website);
    }
}
