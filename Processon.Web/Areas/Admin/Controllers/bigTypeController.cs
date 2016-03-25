using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Processon.Web.Areas.Admin.Controllers
{
    public class bigTypeController : Controller
    {
        // GET: Admin/bigType
        public ActionResult Index()
        {
            return View();
        }

        public string GetBigTypeList()
        {
            return "";
        }
    }
}