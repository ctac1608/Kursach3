using Kursach3.Models;
using Kursach3.Services;
using Kursach3.ViewModels;
using Newtonsoft.Json;
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

        [HttpPost]
        public string GetCreative(CreativeView creative)
        {
            return CreativeService.GetCreative(creative.Id);
        }

    }
}