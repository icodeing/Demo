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
    public class CategoryDAL
    {
        /// <summary>
        /// 获取项目列表
        /// </summary>
        public IList<Category> GetProjectList()
        {
            string sql = "select * from [dbo].[Category]";
            DataSet ds = SqlHelper.ExecuteDataSet(sql);
            IList<Category> category = DataToEntity.DataSetToList<Category>(ds, 0);
            return category;
        }
    }
}
