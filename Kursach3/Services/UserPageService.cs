using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Kursach3.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kursach3.Services
{
    public class UserPageService
    {

        public static string GetUser(string userId)
        {
            using (var db = new ApplicationDbContext())
            {
                return JsonConvert.SerializeObject(db.Users.Find(userId));
            }
        }

        public static string UploadAvatar(string avatar)
        {
            var account = new Account(
                "dqxuyyhh2d",
            "494215851576957",
            "kByBGvzNRvujzAwNt70UfkbQq5k");
            var cloudinary = new Cloudinary(account);
            var uploadParams = new ImageUploadParams
            {
                File = new FileDescription(avatar)
            };
            return cloudinary.Upload(uploadParams).SecureUri.ToString();
        }

        public static void ChangeAvatar(string avatarUrl, string id)
        {
            using(var db = new ApplicationDbContext())
            {
                var user = db.Users.Find(id);
                user.AvatarUrl = avatarUrl;
                db.SaveChanges();
            }
        }

        public static string GetUserCreatives(string userId)
        {
            using (var db = new ApplicationDbContext())
            {
                var creatives = from c in db.Creatives.ToList()
                                orderby c.Name descending
                                select c;
                return JsonConvert.SerializeObject(creatives);
            }
        }

        public static void CreateCreative(Creative creative, Chapter chapter, string userId)
        {
            Creative newCreative = new Creative(creative, userId);
            Chapter newChapter = new Chapter(chapter, newCreative.Id);

            using (var db = new ApplicationDbContext())
            {
                db.Creatives.Add(newCreative);
                db.Chapters.Add(newChapter);
                db.SaveChanges();
            }
        }
    }
}