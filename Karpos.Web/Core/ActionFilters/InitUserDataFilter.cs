
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Controllers;
using Karpos.Datalayer;
using System.Web.Mvc;

namespace Karpos.Web.Core.ActionFilters
{
    public class InitUserDataFilter : ActionFilterAttribute
    {
        public InitUserDataFilter()
        {
           
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            base.OnActionExecuting(filterContext);

            bool authenticatedSession = false;
            if (filterContext.HttpContext.Session != null)
            {
                if (filterContext.HttpContext.Session["UserGuid"] != null)
                {
                    authenticatedSession = true;
                    var viewBag = filterContext.Controller.ViewBag;

                    // set the viewbag values
                    var userGuid = Guid.Parse(filterContext.HttpContext.Session["UserGuid"].ToString());
                    viewBag.Contact = KarposEntityContext.Instance.Logins.FirstOrDefault(n => n.Guid == userGuid).Contact;

                    viewBag.Autheticated = true;
                }
            }

            if(!authenticatedSession)
            {
                filterContext.Result = new RedirectResult("/Login");
            }
        }

    }
}