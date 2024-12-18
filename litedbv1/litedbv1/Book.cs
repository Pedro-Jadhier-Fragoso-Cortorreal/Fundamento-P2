﻿using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace litedbv1
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        [BsonRef ("authors")]
        public Author Author { get; set; }

        public int Year { get; set; }
    }
}
