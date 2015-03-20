namespace CodeMastersFirstBlog
{
    public class CommentWrite
    {
        public string CommentBy { set; get; }
        public string CommentBody { set; get; }

        public CommentWrite(string commentator, string commentDetails)
        {
            CommentBy = commentator;
            CommentBody = commentDetails;
        }
    }
}