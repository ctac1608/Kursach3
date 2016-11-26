using Kursach3.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Kursach3.Controllers
{
    public class CreativeController : Controller
    {
        public ActionResult CreativeReader()
        {
            return View();
        }

        public ActionResult CreativeRedact()
        {
            return View();
        }

        [HttpGet]
        public string GetPopularCreatives()
        {
            return CreativeService.GetPopularCreatives();
        }

        [HttpGet]
        public string GetNewCreatives()
        {
            return CreativeService.GetNewCreatives();
        }
    }
}