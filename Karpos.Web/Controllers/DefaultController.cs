﻿using Karpos.Web.Core.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Karpos.Web.Controllers
{
    public class DefaultController : BaseController
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
    }
}