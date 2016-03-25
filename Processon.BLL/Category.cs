using Processon.DAL;
using Processon.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Processon.BLL
{
    public class CategoryBLL
    {
        CategoryDAL dal = new CategoryDAL();
        /// <summary>
        /// 获取项目列表
        /// </summary>
        /// <returns></returns>
        public IList<Category> GetProjectList()
        {
            return dal.GetProjectList();
        }
    }
}
