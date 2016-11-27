﻿using Kursach3.Models;
using Kursach3.Services;
using MvcLuceneSampleApp.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Kursach3.Controllers
{
    public class HomeController : DefaultController
    {
        public ActionResult Index()
        {
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                LuceneSearch.ClearLuceneIndex();
                LuceneSearch.AddUpdateLuceneIndex(db.Creatives);
            }
            return View();
        }

        [HttpGet]
        public string GetPopularCreatives()
        {
            return HomePageService.GetPopularCreatives();
        }

        [HttpGet]
        public string GetNewCreatives()
        {
            return HomePageService.GetNewCreatives();
        }

        [HttpGet]
        [Authorize]
        public ActionResult AdminPage()
        {
            using (var db = new ApplicationDbContext())
            {
                var users = db.Users.ToList();
                return View(users);
            }
        }
        public ActionResult SearchPage()
        {
            return View();
        }

        [HttpGet]
        [Authorize]
        public ActionResult BanUser(string id)
        {
            using (var db = new ApplicationDbContext())
            {
                var user = db.Users.Find(id);
                user.Ban = !user.Ban;
                db.SaveChanges();
            }
            return RedirectToAction("AdminPage");
        }

        [HttpPost]
        public void SearchResult(string searchRow)
        {
            IEnumerable <object> creative  = LuceneSearch.Search(searchRow);
        }


    }
}