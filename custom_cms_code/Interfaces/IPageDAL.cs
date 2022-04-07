using System;
using System.Collections.Generic;
using System.Text;
using DataLayer;

namespace Interfaces
{
    interface IPageDAL
    {
        public void Save(PageDTO pageDTO);
    }
}
