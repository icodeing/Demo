using Newtonsoft.Json;
using Processon.BLL;
using Processon.Common;
using Processon.Model;
using Processon.Model.ModelView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Processon.Web.Areas.ProjectReport.Controllers
{
    /// <summary>
    /// 项目资金人工审批支付
    /// </summary>
    public class ProjectApprovalReportController : Controller
    {
        // GET: ProjectReport/ProjectApprovalReport
        ExaminationBLL exBll = null;
        CategoryBLL categoryBLL = null;
        BigTypesBLL bigBll = null;
        SmallTypesBLL samllBll = null;
        UnitTypesBLL unitBll = null;
        public ProjectApprovalReportController()
        {
            exBll = new ExaminationBLL();
            categoryBLL = new CategoryBLL();
            bigBll = new BigTypesBLL();
            samllBll = new SmallTypesBLL();
            unitBll = new UnitTypesBLL();
        }
        public ActionResult Index()
        {
         
            return View();
        }

       
        public string GetReport()
        {
            IList<ExaminationView> model = exBll.GetProjectReportList();
            string json = JsonConvert.SerializeObject(model);
            string jsons = JsonHelper.GetJsonResult(json, model.Count);
            //return Json(model, "text/json");
            return jsons;
        }

        public string GetProjectList()
        {
            IList<Category> model= categoryBLL.GetProjectList();
            string json = JsonConvert.SerializeObject(model);
            string jsonResult = JsonHelper.GetJsonResult(json, model.Count);
            return jsonResult;
        }

        /// <summary>
        /// 更新或插入
        /// </summary>
        /// <param name="jsondata">json数据</param>
        /// <param name="isUpdate">true：更新；false：插入</param>
        /// <returns></returns>
        [HttpPost]
        public string UpdateProjectReport(string jsondata,bool isUpdate)
        {
            IList<ExaminationView> model = JsonConvert.DeserializeObject<IList<ExaminationView>>(jsondata);
            //更新表数据
            bool result = exBll.UpDataInformation(model, isUpdate);

            if (result)
                return JsonHelper.Success();
            else
                return JsonHelper.Failure();
        }

        public string GetBigTypetList()
        {
            IList<BigTypes> model= bigBll.GetBigTypeList();
            string json = JsonConvert.SerializeObject(model);
            string jsonResult = JsonHelper.GetJsonResult(json, model.Count);
            return jsonResult;
        }

        public string GetSmaillTypetList()
        {
            IList<SmallTypes> model = samllBll.GetSmallTypeList();
            string json = JsonConvert.SerializeObject(model);
            string jsonResult = JsonHelper.GetJsonResult(json, model.Count);
            return jsonResult;
        }

        public string GetUnitTypetList()
        {
            IList<UnitTypes> model = unitBll.GetUnitTypeList();
            string json = JsonConvert.SerializeObject(model);
            string jsonResult = JsonHelper.GetJsonResult(json, model.Count);
            return jsonResult;
        }
    }
}