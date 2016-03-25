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
    public class BigTypesDAL
    {
        BigTypes bigModel = new BigTypes();

        /// <summary>
        /// 获取大类别的数据列表
        /// </summary>
        public IList<BigTypes> GetBigTypeList()
        {
            string sql = @"select bigID,BigTypeName from [dbo].[BigTypes] order by SortId desc";
            DataSet ds = SqlHelper.ExecuteDataSet(sql);
            IList<BigTypes> model = DataToEntity.DataSetToList<BigTypes>(ds, 0);
            return model;
        }
    }
}
