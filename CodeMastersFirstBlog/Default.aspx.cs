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
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            newPostsHeaderDateLabel.Text = DateTime.Now.ToString();
            GetNewPosts();
        }

        private void GetNewPosts()
        {
            string connectionString = WebConfigurationManager.ConnectionStrings["CodeMastersFirstBlogConnectionString"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT * FROM tbl_article ORDER BY article_id DESC";

            //Execute query
            SqlCommand command = new SqlCommand(query, connection);

            //Read data from database 
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            List<ArticleData> newPostsList = new List<ArticleData>();
            while (reader.Read())
            {
                ArticleData anArticleData = new ArticleData();

                anArticleData.ArticleID = Convert.ToInt32(reader["article_id"]);
                anArticleData.ArticleTitle = reader["article_title"].ToString();
                anArticleData.ArticleAuthor = reader["article_author"].ToString();
                anArticleData.ArticleDescription = reader["article_description"].ToString();
                anArticleData.ArticleDate = reader["article_date_time"].ToString();
                newPostsList.Add(anArticleData);
            }
            reader.Close();

            connection.Close();

            //Display First Article 
            firstIDHolderTextBox.Text = newPostsList[0].ArticleID.ToString();
            newPostsTitleLabel1.Text = newPostsList[0].ArticleTitle;
            newPostsDateLabel1.Text = newPostsList[0].ArticleDate;
            newPostsAuthorLabel1.Text = newPostsList[0].ArticleAuthor;

            string tempDesc1 = newPostsList[0].ArticleDescription;
            string tempDesc2 = "";
            for (int i = 0; i < tempDesc1.Length; i++)
            {
                tempDesc2 += tempDesc1[i];
                if (i>250)
                {
                    break;
                }
            }
            newPostsDescriptionLabel1.Text = Server.HtmlDecode(tempDesc2)+". . .";

            //Display Second Article
            secondIDHolderTextBox.Text = newPostsList[1].ArticleID.ToString();
            newPostsTitleLabel2.Text = newPostsList[1].ArticleTitle;
            newPostsDateLabel2.Text = newPostsList[1].ArticleDate;
            newPostsAuthorLabel2.Text = newPostsList[1].ArticleAuthor;

            string tempDesc3 = newPostsList[0].ArticleDescription;
            string tempDesc4 = "";
            for (int i = 0; i < tempDesc3.Length; i++)
            {
                tempDesc4 += tempDesc3[i];
                if (i > 250)
                {
                    break;
                }
            }
            newPostsDescriptionLabel2.Text = Server.HtmlDecode(tempDesc4) + ". . .";

            //Display Third Article
            thirdIDHolderTextBox.Text = newPostsList[2].ArticleID.ToString();
            newPostsTitleLabel3.Text = newPostsList[2].ArticleTitle;
            newPostsDateLabel3.Text = newPostsList[2].ArticleDate;
            newPostsAuthorLabel3.Text = newPostsList[2].ArticleAuthor;

            string tempDesc5 = newPostsList[2].ArticleDescription;
            string tempDesc6 = "";
            for (int i = 0; i < tempDesc5.Length; i++)
            {
                tempDesc6 += tempDesc5[i];
                if (i > 250)
                {
                    break;
                }
            }
            newPostsDescriptionLabel3.Text = Server.HtmlDecode(tempDesc2) + ". . .";

            //Display Fourth Article
            fourthIDHolderTextBox.Text = newPostsList[3].ArticleID.ToString();
            newPostsTitleLabel4.Text = newPostsList[3].ArticleTitle;
            newPostsDateLabel4.Text = newPostsList[3].ArticleDate;
            newPostsAuthorLabel4.Text = newPostsList[3].ArticleAuthor;

            string tempDesc7 = newPostsList[0].ArticleDescription;
            string tempDesc8 = "";
            for (int i = 0; i < tempDesc7.Length; i++)
            {
                tempDesc8 += tempDesc7[i];
                if (i > 250)
                {
                    break;
                }
            }
            newPostsDescriptionLabel4.Text = Server.HtmlDecode(tempDesc8) + ". . .";
        }

        protected void firstReadMoreButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("ArticleDetails.aspx?SelectedArticleID=" + Server.UrlEncode(firstIDHolderTextBox.Text));
        }

        protected void secondReadMoreButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("ArticleDetails.aspx?SelectedArticleID=" + Server.UrlEncode(secondIDHolderTextBox.Text));
        }

        protected void thirdReadMoreButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("ArticleDetails.aspx?SelectedArticleID=" + Server.UrlEncode(thirdIDHolderTextBox.Text));
        }

        protected void fourthReadMoreButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("ArticleDetails.aspx?SelectedArticleID=" + Server.UrlEncode(fourthIDHolderTextBox.Text));
        }
    }

}