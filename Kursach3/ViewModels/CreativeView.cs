using Kursach3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kursach3.ViewModels
{
    public class CreativeView
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ChapterView[] Chapters { get; set; }

        public CreativeView() { }

        public CreativeView(Creative creative, ChapterView[] chapters)
        {
            Id = creative.Id;
            Name = creative.Name;
            Chapters = chapters;
        }
    }
}