using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_4_Relation
{
    internal class Article
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        public List<Comment> Comments = new List<Comment>(); // 建議給一個空的List
        public bool IsDeleted { get; set; }
    }
}
