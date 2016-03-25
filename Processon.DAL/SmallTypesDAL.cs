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
    public class SmallTypesDAL
    {
        /// <summary>
        /// 获取小类别的数据列表
        /// </summary>
        /// <returns></returns>
        public IList<Model.SmallTypes> GetSmallTypeList()
        {
            string sql = @"select SmallTypeId,SmallTypeName from [dbo].[SmallTypes] order by SortId desc";
            DataSet ds = SqlHelper.ExecuteDataSet(sql);
            IList<Model.SmallTypes> model = DataToEntity.DataSetToList<Model.SmallTypes>(ds, 0);
            return model;
        }
    }
}
