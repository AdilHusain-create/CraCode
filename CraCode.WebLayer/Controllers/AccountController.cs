using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CraCode.WebLayer.Controllers
{
    public class AccountController : Controller
    {

        public ActionResult  StudentRegister()
        {
            return View();
        }

        public ActionResult ProfessorRegister()
        {
            return View();
        }

        public ActionResult CompanyRegister()
        {
            return View();
        }
    }
}