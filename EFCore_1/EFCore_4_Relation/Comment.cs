﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_4_Relation
{
    internal class Comment
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public Article TheArticle { get; set; }
        public int TheArticleId { get; set; }
    }
}
