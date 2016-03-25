using Processon.DAL;
using Processon.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Processon.BLL
{
    public class SysMenusBLL
    {
        SysMenusDAL menuDal = new SysMenusDAL();
        public IList<SysMenus> GetMenus()
        {
            return menuDal.GetMenus();
        }
    }
}
