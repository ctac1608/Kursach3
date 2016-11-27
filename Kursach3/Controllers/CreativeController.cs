using Kursach3.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Kursach3.Controllers
{
    public class CreativeController : DefaultController
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
        public string GetCreative()
        {
            return CreativeService.GetCreative();
        }

    }
}