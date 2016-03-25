using Processon.Common;
using Processon.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Processon.DAL
{
    public class SysMenusDAL
    {
        public IList<SysMenus> GetMenus()
        {
            string sql = "select * from sysMenus";
            DataSet dt = SqlHelper.ExecuteDataSet(sql);
            IList< SysMenus> menusModel = DataToEntity.DataSetToList<SysMenus>(dt,0);
            return menusModel;

        }
    }
}
