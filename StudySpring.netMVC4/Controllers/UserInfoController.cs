using BLL;
using IBLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudySpring.netMVC4.Controllers
{
    public class UserInfoController : Controller
    {
        //
        // GET: /UserInfo/
        IUserInfoService userInfoService { get; set; }
        public ActionResult Index()
        {
           // userInfoService = new UserInfoService();
            string msg = userInfoService.ShowMvcMsg();
            ViewBag.message = msg;
            return View();
        }

    }
}
