using Kursach3.Models;
using Kursach3.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kursach3.Services
{
    public class HomePageService
    {
        private const int CountDisplayCreatives = 3;

        public static string SearchResult(IEnumerable<Creative> searchCreatives)
        {
            UserView user = new UserView();
            List<Creative> creatives = new List<Creative>();

            using (var db = new ApplicationDbContext())
            {
                foreach (Creative searchCreative in searchCreatives)
                {
                    creatives.Add(db.Creatives.Find(searchCreative.Id));
                    user.Id = db.Creatives.Find(searchCreative.Id).UserId;
                }
                user.Login = db.Users.Find(user.Id).Login;
            }
            user.Creatives = creatives.ToArray();

            return JsonConvert.SerializeObject(user);
        }

        public static string GetPopularCreatives()
        {
            List<UserView> users = new List<UserView>();

            using (var db = new ApplicationDbContext())
            {
                var creatives = from c in db.Creatives.ToList()
                                orderby c.Rank descending
                                select c;

                foreach (Creative creative in creatives)
                {
                    users.Add(new UserView()
                    {
                        Id = creative.UserId,
                        Login = db.Users.Find(creative.UserId).Login,
                        Creatives = new Creative[] { creative }
                    });
                }

                return GetFiveCreatives(users);
            }
        }

        public static string GetNewCreatives()
        {
            List<UserView> users = new List<UserView>();

            using (var db = new ApplicationDbContext())
            {
                var creatives = from c in db.Creatives.ToList()
                                orderby c.CreateData descending
                                select c;

                foreach (Creative creative in creatives)
                {
                    users.Add(new UserView()
                    {
                        Id = creative.UserId,
                        Login = db.Users.Find(creative.UserId).Login,
                        Creatives = new Creative[] { creative }
                    });
                }

                return GetFiveCreatives(users);
            }
        }

        public static string GetFiveCreatives(List<UserView> users)
        {
            return JsonConvert.SerializeObject(users.Take(CountDisplayCreatives));
        }

    }
}