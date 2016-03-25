using Processon.Common;
using Processon.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Processon.DAL
{
    public class UnitTypesDAL
    {
        UnitTypes uModel = new UnitTypes();
        /// <summary>
        /// 获取单位类型数据
        /// </summary>
        /// <returns></returns>
        public IList<UnitTypes> GetUnitTypeList()
        {
            string sql = @"select * from [dbo].[UnitTypes] order by SortId desc";
            DataSet ds = SqlHelper.ExecuteDataSet(sql);
            IList<UnitTypes> model = DataToEntity.DataSetToList<UnitTypes>(ds, 0);
            return model;
        }

        public bool UpDataUnit(UnitTypes unitModel, bool isUpdate)
        {
            string sql = string.Empty;
            if (isUpdate)
            {
                //更新
                sql = "update [dbo].[UnitTypes] set UnitName=@UnitName where UnitId=@UnitId";
            }else
            {
                //新增
                sql = "insert [dbo].[UnitTypes] (UnitName) values(@UnitName)";
            }
            SqlParameter[] ps = new SqlParameter[]
            {
                new SqlParameter("@UnitName",SqlDbType.NVarChar),
                new SqlParameter("@UnitId",SqlDbType.UniqueIdentifier)
            };
            ps[0].Value = unitModel.UnitName;
            ps[1].Value = unitModel.UnitId;
            int resultCount = SqlHelper.ExecuteNonQuery(sql, ps);
            if (resultCount > 0)
                return true;
            else
                return false;
        }

        public bool DeleteUnit(Guid gid)
        {
            string sql = "delete [dbo].[UnitTypes] where UnitId=@UnitId";
            SqlParameter[] ps = new SqlParameter[]
            {
                new SqlParameter("@UnitId",SqlDbType.UniqueIdentifier)
            };
            ps[0].Value = gid;
            int resultCount = SqlHelper.ExecuteNonQuery(sql, ps);
            if (resultCount > 0)
                return true;
            else
                return false;
        }
    }
}
