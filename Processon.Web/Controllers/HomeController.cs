using Processon.BLL;
using Processon.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Processon.Web.Controllers
{
    public class HomeController : Controller
    {
        SysMenusBLL mBll;
        public HomeController()
        {
            mBll = new SysMenusBLL();
        }
        // GET: Home
        public ActionResult Index()
        {
            IList<SysMenus> mModel = mBll.GetMenus();
            ViewBag.MenusList = mModel;
            return View();
        }
    }
}