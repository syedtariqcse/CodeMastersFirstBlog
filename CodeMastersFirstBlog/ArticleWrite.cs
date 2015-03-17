namespace CodeMastersFirstBlog
{
    public class ArticleWrite
    {
        public ArticleWrite(string title, string author, string description)
        {
            Title = title;
            Author = author;
            Description = description;
        }

        public string Title { set; get; }
        public string Author { set; get; }
        public string Description { set; get; }
    }
}