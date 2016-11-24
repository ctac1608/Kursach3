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
        public void Create(Creative creative)
        {
            UserPageService.CreateCreative(creative, User.Identity.GetUserId());

        }

        [HttpPost]
        public void ChangeAvatar(byte[] src)
        {
            //string base64str = src.Substring(src.IndexOf(',') + 1);
            //byte[] bytes = Convert.FromBase64String(base64str);
            //File.WriteAllBytes("image.png", bytes);
        }

    }
}