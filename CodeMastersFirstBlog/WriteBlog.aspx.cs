using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CodeMastersFirstBlog
{
    public partial class WriteBlog : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void createArticleButton_Click(object sender, EventArgs e)
        {
            string articleTitle = articleTitleTextBox.Text;
            string articleAuthor = articleAuthorTextBox.Text;
            string articleDescription = articleDescriptionTextArea.InnerHtml;

            ArticleWrite anArticle = new ArticleWrite(articleTitle, articleAuthor, articleDescription);

            if (WriteAnArticle(anArticle))
            {
                Label1.Text = "Article is created successfully!";
            }
            else
            {
                Label1.Text = "oops!";
            }
        }

        private bool WriteAnArticle(ArticleWrite anArticle)
        {
            string connectionString = WebConfigurationManager.ConnectionStrings["CodeMastersFirstBlogConnectionString"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);

            DateTime dateTime = DateTime.Now;

            //Write insert query
            string query = "INSERT INTO tbl_article (article_author,article_title,article_description, article_date_time, article_viewer) VALUES('" + anArticle.Author + "','" + anArticle.Title + "','" + anArticle.Description + "','" + DateTime.Now + "','" + 0 + "')";

            //Execute query
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            int rowAffected = command.ExecuteNonQuery(); 
            connection.Close();

            return rowAffected > 0;
        }
    }
}