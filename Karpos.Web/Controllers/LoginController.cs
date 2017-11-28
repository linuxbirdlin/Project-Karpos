using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BCrypt.Net;
using Karpos.Web.Core.Base;
using Karpos.Datalayer;

namespace Karpos.Web.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DoLogin(string username, string password)
        {
            var user = KarposEntityContext.Instance.Logins.FirstOrDefault(n => n.Username == username);
            if(user == null)
            {
                return Redirect("/Login?error=true");
            }


            string hashed = user.Password;
            bool matches = BCrypt.Net.BCrypt.Verify(password, hashed);
            if (matches)
            {
                Session["UserGuid"] = user.Guid;
                return RedirectToAction("Index", "Default");
            }
            else
            {
                return Redirect("/Login?error=true");
            }

        }

        public ActionResult Logout()
        {
            Session.Abandon();
            return RedirectToAction("Index");
        }
    }
}