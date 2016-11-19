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

        public static void CreateCreative(Creative creative, string userId)
        {
            Creative newCreative = new Creative(creative, userId);


        }
    }
}