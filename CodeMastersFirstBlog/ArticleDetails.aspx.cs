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
    public partial class ArticleDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string ID = Server.UrlDecode(Request.QueryString["SelectedArticleID"]);
            GetArticleDetails(Convert.ToInt32(ID));
        }
        private void GetArticleDetails(int id)
        {
            string connectionString = WebConfigurationManager.ConnectionStrings["CodeMastersFirstBlogConnectionString"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT * FROM tbl_article WHERE article_id='"+id+"'";

            //Execute query
            SqlCommand command = new SqlCommand(query, connection);

            //Read data from database 
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            //List<ArticleData> newPostsList = new List<ArticleData>();
            ArticleData anArticleData = new ArticleData();
            while (reader.Read())
            {
                

                anArticleData.ArticleTitle = reader["article_title"].ToString();
                anArticleData.ArticleAuthor = reader["article_author"].ToString();
                anArticleData.ArticleDescription = reader["article_description"].ToString();
                anArticleData.ArticleDate = reader["article_date_time"].ToString();
                //newPostsList.Add(anArticleData);
            }
            reader.Close();

            connection.Close();

            selectedPostsTitleLabel.Text = anArticleData.ArticleTitle;
            selectedPostsDateLabel.Text = anArticleData.ArticleDate;
            selectedPostsAuthorLabel.Text = anArticleData.ArticleAuthor;

            //string tempDesc1 = newPostsList[0].ArticleDescription;
            //string tempDesc2 = "";
            //for (int i = 0; i < tempDesc1.Length; i++)
            //{
            //    tempDesc2 += tempDesc1[i];
            //    if (i > 400)
            //    {
            //        break;
            //    }
            //}
            selectedPostsDescriptionLabel.Text = Server.HtmlDecode(anArticleData.ArticleDescription);
        }
    }
}