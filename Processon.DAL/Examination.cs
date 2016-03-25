using Processon.Common;
using Processon.Model;
using Processon.Model.ModelView;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Processon.DAL
{
    public class ExaminationDAL
    {
        /// <summary>
        /// 项目资金人工审批支付查询
        /// </summary>
        /// <returns></returns>
        public IList<ExaminationView> GetProjectReportList()
        {
            string sql = @"select * from [dbo].[Examination] e left join [dbo].[HeadCheck] h on e.hId=h.h_Id
left join [dbo].[FinancialCheck] f on e.fId=f.f_Id
left join [dbo].[SupervisionCheck] s on e.sId=s.s_Id
left join [dbo].[CashierCheck] c on e.CashierCheckId=c.c_Id
left join [dbo].[MoneyManagementCheck] m on e.mId=m.m_Id
left join [dbo].[OtherCheck] o on e.oId=o.o_Id
left join [dbo].[Category] g on e.cId=g.CategoryId
left join [dbo].[BigTypes] b on e.BigType=b.bigID
left join [dbo].[SmallTypes] t on e.SamllType=t.SmallTypeId";
           DataSet ds= SqlHelper.ExecuteDataSet(sql);
           IList< ExaminationView> examationodel= DataToEntity.DataSetToList<ExaminationView>(ds, 0);
            return examationodel;
        }

        public bool UpDataExamination(Examination examination,bool isUpdate)
        {
            string IpdateOrInsert = isUpdate ? "update" : "insert";
            SqlParameter[] ps = null;
            string sql = string.Empty;
            try
            {
                if (isUpdate == true)
                {
                    sql = string.Format(@"update [dbo].[Examination] set cId=@CategoryId,BigType=@BigType,Brand=@Brand,SamllType=@SamllType,
Number=@Number,UnitId=@UnitId,Singleton=@Singleton,UnitPrice=@UnitPrice,CountPrice=@CountPrice,CreateTime=@CreateTime where  EId=@EId ", examination.CId,
    examination.BigType, examination.Brand, examination.CashierCheckId, examination.CountPrice, examination.CreateTime, examination.FId,
    examination.HId, examination.MId, examination.Number, examination.OId, examination.SamllType, examination.SId, examination.Singleton,
    examination.UnitId, examination.UnitPrice);
                }
                else if (isUpdate == false)
                {
                    sql = @"insert  [dbo].[Examination] (cId,BigType,Brand,SamllType,Number,Unit,Singleton,UnitPrice,CountPrice,CreateTime) 
values(@CategoryId,@BigType,@Brand,@SamllType,@Number,@Unit,@Singleton,@UnitPrice,@CountPrice,@CreateTime)";
                }
                ps = new SqlParameter[]
                 {
                new SqlParameter("@CategoryId",SqlDbType.UniqueIdentifier),
                new SqlParameter("@BigType",SqlDbType.UniqueIdentifier),
                new SqlParameter("@Brand",SqlDbType.NVarChar),
                 new SqlParameter("@SamllType",SqlDbType.UniqueIdentifier),
                 new SqlParameter("@Number",SqlDbType.Int),
                 new SqlParameter("@UnitId",SqlDbType.UniqueIdentifier),
                 new SqlParameter("@Singleton",SqlDbType.Int),
                 //new SqlParameter("@CashierCheckId",SqlDbType.UniqueIdentifier),
                
                 new SqlParameter("@UnitPrice",SqlDbType.Decimal),
                  new SqlParameter("@CountPrice",SqlDbType.Decimal),
                 new SqlParameter("@CreateTime",SqlDbType.DateTime),
                 new SqlParameter("@EId",SqlDbType.UniqueIdentifier),
                 
                 //new SqlParameter("@FId",SqlDbType.UniqueIdentifier),
                 //new SqlParameter("@HId",SqlDbType.UniqueIdentifier),
                 //new SqlParameter("@MId",SqlDbType.UniqueIdentifier),
                 // 
                 // new SqlParameter("@OId",SqlDbType.UniqueIdentifier),
                 
                 // new SqlParameter("@SId",SqlDbType.UniqueIdentifier),
                 // 
                 // 
                 // 
                 };
                ps[0].Value = examination.CId;
                ps[1].Value = examination.BigType;
                ps[2].Value = examination.Brand;
                ps[3].Value = examination.SamllType;
                ps[4].Value = examination.Number;
                ps[5].Value = examination.UnitId;
                ps[6].Value = examination.Singleton;
                ps[7].Value = examination.UnitPrice;
                ps[8].Value = examination.CountPrice;
                ps[9].Value = examination.CreateTime;
                ps[10].Value = examination.EId;
                //ps[9].Value = examination.MId;
                //ps[10].Value = examination.Number;
                //ps[11].Value = examination.OId;
                //ps[12].Value = examination.SId;
                //ps[13].Value = examination.Singleton;
                //ps[14].Value = examination.Unit;
                //ps[15].Value = examination.UnitPrice;
            }
            catch (Exception ex)
            {

                throw;
            }
          int resultCount= SqlHelper.ExecuteNonQuery(sql,ps);
            if (resultCount > 0)
                return true;
            else
                return false;
        }
    }
}
