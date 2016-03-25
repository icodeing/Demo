using Processon.DAL;
using Processon.Model;
using Processon.Model.ModelView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Processon.BLL
{
    public class ExaminationBLL
    {
        ExaminationDAL dal = new ExaminationDAL();
        /// <summary>
        /// 项目资金人工审批支付查询
        /// </summary>
        /// <returns></returns>
        public IList<ExaminationView> GetProjectReportList()
        {
            return dal.GetProjectReportList();
        }

       public bool UpDataInformation(IList<ExaminationView> model,bool isUpdate)
        {
            //先更新Examination基础数据表
            Examination exModel = null;
            bool flag=false;
            for (int i = 0; i < model.Count; i++)
            {
                exModel = new Examination()
                {
                     BigType=model[i].BigID,
                      Brand=model[i].Brand,
                       CashierCheckId=model[i].CashierCheckId,
                        CId=model[i].CategoryId,
                         CountPrice=model[i].CountPrice,
                          CreateTime=model[i].CreateTime==null?Convert.ToDateTime(DateTime.Now):model[i].CreateTime,
                           EId=model[i].EId,
                            FId=model[i].FId,
                             HId=model[i].HId,
                              MId=model[i].MId,
                               Number=model[i].Number,
                                OId=model[i].OId,
                                 SamllType=model[i].SmallTypeId,
                                  SId=model[i].SId,
                                   Singleton=model[i].Singleton,
                    UnitId = model[i].UnitId,
                                     UnitPrice=model[i].UnitPrice
                };
                flag= dal.UpDataExamination(exModel, isUpdate);
            }
            if (flag)
                return true;
            else
                return false;
        }
    }
}
