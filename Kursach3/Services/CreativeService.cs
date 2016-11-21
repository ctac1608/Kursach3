﻿using Kursach3.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kursach3.Services
{
    public class CreativeService
    {
        private static int CountDisplayCreatives = 5;

        public static string GetPopularCreatives()
        {
            using (var db = new ApplicationDbContext())
            {
                var creatives = from c in db.Creatives.ToList()
                                orderby c.Rank descending
                                select c;
                return GetFiveCreatives(creatives);
            }
        }

        public static string GetNewCreatives()
        {
            using (var db = new ApplicationDbContext())
            {
                var creatives = from c in db.Creatives.ToList()
                                orderby c.CreateData descending
                                select c;
                return GetFiveCreatives(creatives);                
            }
        }

        public static string GetFiveCreatives(IOrderedEnumerable<Creative> creatives)
        {
            int i = 0;
            var fiveCreatives = creatives.Skip(i).Take(CountDisplayCreatives);
            i += CountDisplayCreatives;
            return JsonConvert.SerializeObject(fiveCreatives);
        }

    }
}