﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kursach3.Models
{
    public class Chapter
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        public int Position { get; set; }
        public int CreativeId { get; set; }
    }
}