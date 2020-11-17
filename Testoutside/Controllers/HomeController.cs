using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestOutside.Common;
using TestOutside.Models;

namespace TestOutside.Controllers
{
    public class HomeController : Controller
    {
        private ModelInfo _dbContext = new ModelInfo();

        public ActionResult Index()
        {
            return View();
        }

        public String SendMail(string toEmail, string subject, string body)
        {
            try
            {
                var Email = toEmail;
                var Subject = subject;
                var Body = body;

                MailHelper.SendMail(Email, Subject, Body);
                return "Sent email";
            }
            catch(Exception ex)
            {
                throw ex;
            }

        }

        public JsonResult GetAllDataFromDB()
        {
            try
            {
                List<Info> infoes = new List<Info>();

                infoes = (from s in _dbContext.Infoes select s).ToList();


                return Json(infoes, JsonRequestBehavior.AllowGet);
            }
            catch(Exception ex)
            {
                return Json("", JsonRequestBehavior.AllowGet);
            }
            
        }
    }
}