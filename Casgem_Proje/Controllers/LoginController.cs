using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Casgem_Proje.Models.Entities;

namespace Casgem_Proje.Controllers
{
    public class LoginController : Controller
    {
        CasgemPortfolioEntities1 db = new CasgemPortfolioEntities1();
       [HttpGet]
        public ActionResult Index()
        {
            return View();
        } 
        [HttpPost]
        public ActionResult Index(TableAdmin admin)
        {
            var values = db.TableAdmin.FirstOrDefault(x => x.Username == admin.Username && x.Password == admin.Password);
            if (values != null)
            {
                FormsAuthentication.SetAuthCookie(values.Username, false);
                Session["kullanici"] = values.Username.ToString();
                return RedirectToAction("Index", "WhoAmI");
            }
            else
            {
                return View();
            }
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction("Index", "Login");
        }
    }
}