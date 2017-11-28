using Karpos.Datalayer;
using Karpos.Web.Core.ActionFilters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Karpos.Web.Core.Base
{
    [InitUserDataFilter]
    public class BaseController : Controller
    {
        protected Guid UserGuid { get; set; }
        protected bool IsAuthenticated { get; set; }
        protected KarposEntities dbContext = null;
        public BaseController()
        {
            //if (Session["UserGuid"] != null)
            //{
            //    UserGuid = Guid.Parse(Session["UserGuid"].ToString());
            //    IsAuthenticated = true;
            //}

            //dbContext = KarposEntityContext.Instance;
        }
    }
}