using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeMastersFirstBlog
{
    public class CommentRead
    {
        public int CommentID { get; set; }
        public string CommentBy { get; set; }
        public string Comment { get; set; }
        public string CommentDateTime { get; set; }
        public int CommentArticleID { get; set; }

        public CommentRead()
        {
            
        }
    }
}