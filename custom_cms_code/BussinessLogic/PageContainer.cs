using System;
using System.Collections.Generic;
using System.Text;

namespace BussinessLogic
{
    class PageContainer
    {
        public List<Page> GetAllPages()
        {
            List<Page> pages = new List<Page>();

            return pages;
        }

        public Page FindPageById(int id)
        {
            return new Page(1, 1, "/index.php");
        }
    }
}
