﻿using Chimper.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Chimper.Controllers
{
    public class BlogController : BaseController
    {
        // GET: Blog
        public ActionResult Index()
        {
            ViewBag.Cover = "Our Blog";
            return View();
        }
        public ActionResult ChangeLang(string lang)
        {
            new LanguageM().SetLanguage(lang);
            return RedirectToAction("Index");
        }
    }
}