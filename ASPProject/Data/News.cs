﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPProject.Data
{
    public class News
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        public string Fotos { get; set; }
        public DateTime Data { get; set; }
    }
}
