using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CraCode.ModelLayer.Models;

namespace CraCode.WebLayer.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public ActionResult StudentLogin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult VerifyStudentLogin(Student student)
        {
            return View();
        }

        public ActionResult ProfessorLogin()
        {
            return View();
        }

        public ActionResult CompanyLogin()
        {
            return View();
        }

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