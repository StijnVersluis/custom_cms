using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public interface IPage
    {
        public void EditPage(PageDTO page);
        public void DeletePage(PageDTO page);
    }
}
