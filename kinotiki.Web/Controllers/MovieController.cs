﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using kinotiki.BLL.EmailHelper;

namespace kinotiki.Web.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ActionResult Index(int id)
        {
            return View();
        }
    }
}