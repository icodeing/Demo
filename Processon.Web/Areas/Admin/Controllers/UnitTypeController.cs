using Newtonsoft.Json;
using Processon.BLL;
using Processon.Common;
using Processon.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Processon.Web.Areas.Admin.Controllers
{
    public class UnitTypeController : Controller
    {
        // GET: Admin/UnitType
        UnitTypesBLL uBll = null;

        public UnitTypeController()
        {
            uBll = new UnitTypesBLL();
        }
        public ActionResult Index()
        {
            return View();
        }

        public string GetUnitJson()
        {
            IList<UnitTypes> model = uBll.GetUnitTypeList();
            string json = JsonConvert.SerializeObject(model);
            string jsonResult = JsonHelper.GetJsonResult(json, model.Count);
            return jsonResult;
        }

        public string UpdateUnit(string jsondata,bool isUpdate)
        {
            UnitTypes model = JsonConvert.DeserializeObject<UnitTypes>(jsondata);
            bool result = uBll.UpDataUnit(model, isUpdate);
            if (result)
                return JsonHelper.Success();
            else
                return JsonHelper.Failure();
        }

        public string DeleteUnitTypes(string jsondata)
        {
            UnitTypes model = JsonConvert.DeserializeObject<UnitTypes>(jsondata);
            //IList<UnitTypes> model = JsonConvert.DeserializeObject<IList<UnitTypes>>(jsondata);
            bool result = uBll.DeleteUnit(model.UnitId);
            if (result)
                return JsonHelper.Success();
            else
                return JsonHelper.Failure();
        }
    }
}