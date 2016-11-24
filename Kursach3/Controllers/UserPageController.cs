using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Kursach3.Models;
using Kursach3.Services;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Kursach3.Controllers
{
    public class UserPageController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public string GetUser()
        {
            return UserPageService.GetUser(User.Identity.GetUserId());
        }

        [HttpGet]
        public string GetUserCreatives()
        {
            return UserPageService.GetUserCreatives(User.Identity.GetUserId());
        }

        [HttpPost]
        public void Create(Creative creative, Chapter chapter)
        {
            UserPageService.CreateCreative(creative, chapter, User.Identity.GetUserId());
        }

        [HttpPost]
        public void ChangeAvatar(string src)
        {
            UserPageService.ChangeAvatar(UserPageService.UploadAvatar(src), User.Identity.GetUserId());
        }
    }
}