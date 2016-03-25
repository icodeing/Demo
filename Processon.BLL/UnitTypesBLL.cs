using Processon.DAL;
using Processon.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Processon.BLL
{
    public class UnitTypesBLL
    {
        UnitTypesDAL dal = new UnitTypesDAL();

        /// <summary>
        /// 获取单位类型数据
        /// </summary>
        /// <returns></returns>
        public IList<UnitTypes> GetUnitTypeList()
        {
            return dal.GetUnitTypeList();
        }

        public bool UpDataUnit(UnitTypes model, bool isUpdate)
        {
            bool falg = false;
            UnitTypes unitModel = new UnitTypes()
            {
                CreateTime = DateTime.Now,
                UnitName = model.UnitName,
                UnitId = model.UnitId
            };
            return dal.UpDataUnit(unitModel, isUpdate);
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool DeleteUnit(Guid unitId)
        {
            return dal.DeleteUnit(unitId);
        }
    }
}
