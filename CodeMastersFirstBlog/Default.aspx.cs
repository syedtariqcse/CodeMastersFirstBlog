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
        int index = 0;
        private int newPostCounter = 0;
        private int mostViewedPostCounter = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            newPostsHeaderDateLabel.Text = DateTime.Now.ToString();
            mostViewedPostsHeaderDateLabel.Text = DateTime.Now.ToString();
            GetNewPosts();
            FindMostViewedPosts();
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
                anArticleData.ArticleViewer = Convert.ToInt32(reader["article_viewer"]);
                newPostsList.Add(anArticleData);
            }
            reader.Close();

            connection.Close();

            newPostCounter = newPostsList.Count;

            //Display First Article 
            if (newPostCounter - index >= 1)
            {
                firstIDHolderTextBox.Text = newPostsList[index].ArticleID.ToString();
                firstViewerHolderTextBox.Text = newPostsList[index].ArticleViewer.ToString();
                newPostsTitleLabel1.Text = newPostsList[index].ArticleTitle;
                newPostsDateLabel1.Text = newPostsList[index].ArticleDate;
                newPostsAuthorLabel1.Text = "Author: " + newPostsList[index].ArticleAuthor;

                string tempDesc1 = newPostsList[0].ArticleDescription;
                string tempDesc2 = "";
                for (int i = 0; i < tempDesc1.Length; i++)
                {
                    tempDesc2 += tempDesc1[i];
                    if (i > 250)
                    {
                        break;
                    }
                }
                newPostsDescriptionLabel1.Text = Server.HtmlDecode(tempDesc2) + ". . .";
            }
            else
            {
                newPostsTitleLabel1.Text = "";
                newPostsDateLabel1.Text = "";
                newPostsAuthorLabel1.Text = "";
                newPostsDescriptionLabel1.Text = "";
                firstReadMoreButton.Visible = false;
            }

            //Display Second Article
            if (newPostCounter - index >= 2)
            {
                secondIDHolderTextBox.Text = newPostsList[index + 1].ArticleID.ToString();
                secondViewerHolderTextBox.Text = newPostsList[index + 1].ArticleViewer.ToString();
                newPostsTitleLabel2.Text = newPostsList[index + 1].ArticleTitle;
                newPostsDateLabel2.Text = newPostsList[index + 1].ArticleDate;
                newPostsAuthorLabel2.Text = "Author: " + newPostsList[index + 1].ArticleAuthor;

                string tempDesc3 = newPostsList[index + 1].ArticleDescription;
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
            }
            else
            {
                newPostsTitleLabel2.Text = "";
                newPostsDateLabel2.Text = "";
                newPostsAuthorLabel2.Text = "";
                newPostsDescriptionLabel2.Text = "";
                secondReadMoreButton.Visible = false;
            }

            //Display Third Article
            if (newPostCounter - index >= 3)
            {
                thirdIDHolderTextBox.Text = newPostsList[index + 2].ArticleID.ToString();
                thirdViewerHolderTextBox.Text = newPostsList[index + 2].ArticleViewer.ToString();
                newPostsTitleLabel3.Text = newPostsList[index + 2].ArticleTitle;
                newPostsDateLabel3.Text = newPostsList[index + 2].ArticleDate;
                newPostsAuthorLabel3.Text = "Author: " + newPostsList[index + 2].ArticleAuthor;

                string tempDesc5 = newPostsList[index + 2].ArticleDescription;
                string tempDesc6 = "";
                for (int i = 0; i < tempDesc5.Length; i++)
                {
                    tempDesc6 += tempDesc5[i];
                    if (i > 250)
                    {
                        break;
                    }
                }
                newPostsDescriptionLabel3.Text = Server.HtmlDecode(tempDesc6) + ". . .";
            }
            else
            {
                newPostsTitleLabel3.Text = "";
                newPostsDateLabel3.Text = "";
                newPostsAuthorLabel3.Text = "";
                newPostsDescriptionLabel3.Text = "";
                thirdReadMoreButton.Visible = false;
            }

            //Display Fourth Article
            if (newPostCounter - index >= 4)
            {
                fourthIDHolderTextBox.Text = newPostsList[index + 3].ArticleID.ToString();
                fourthViewerHolderTextBox.Text = newPostsList[index + 3].ArticleViewer.ToString();
                newPostsTitleLabel4.Text = newPostsList[index + 3].ArticleTitle;
                newPostsDateLabel4.Text = newPostsList[index + 3].ArticleDate;
                newPostsAuthorLabel4.Text = "Author: " + newPostsList[index + 3].ArticleAuthor;

                string tempDesc7 = newPostsList[index + 3].ArticleDescription;
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
            else
            {
                newPostsTitleLabel4.Text = "";
                newPostsDateLabel4.Text = "";
                newPostsAuthorLabel4.Text = "";
                newPostsDescriptionLabel4.Text = "";
                fourthReadMoreButton.Visible = false;
            }
        }

        private void FindMostViewedPosts()
        {
            string connectionString = WebConfigurationManager.ConnectionStrings["CodeMastersFirstBlogConnectionString"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT article_viewer FROM tbl_article";

            //Execute query
            SqlCommand command = new SqlCommand(query, connection);

            //Read data from database 
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            List<int> visitorList = new List<int>();
            while (reader.Read())
            {
                visitorList.Add(Convert.ToInt32(reader["article_viewer"]));
            }
            reader.Close();

            connection.Close();

            visitorList.Sort();

            List<ArticleData> mostViewedPostsList = new List<ArticleData>();
            for (int i = visitorList.Count; i >0; i--)
            {
                //string connectionString = WebConfigurationManager.ConnectionStrings["CodeMastersFirstBlogConnectionString"].ConnectionString;
                //SqlConnection connection = new SqlConnection(connectionString);

                string query2 = "SELECT * FROM tbl_article WHERE article_viewer='"+visitorList[i-1]+"'";

                //Execute query
                SqlCommand command2 = new SqlCommand(query2, connection);

                //Read data from database 
                connection.Open();
                SqlDataReader reader2 = command2.ExecuteReader();

                
                while (reader2.Read())
                {
                    ArticleData anArticleData = new ArticleData();

                    anArticleData.ArticleID = Convert.ToInt32(reader2["article_id"]);
                    anArticleData.ArticleTitle = reader2["article_title"].ToString();
                    anArticleData.ArticleAuthor = reader2["article_author"].ToString();
                    anArticleData.ArticleDescription = reader2["article_description"].ToString();
                    anArticleData.ArticleDate = reader2["article_date_time"].ToString();
                    anArticleData.ArticleViewer = Convert.ToInt32(reader2["article_viewer"]);
                    mostViewedPostsList.Add(anArticleData);
                }
                reader2.Close();

                connection.Close();
            }

            mostViewedPostCounter = mostViewedPostsList.Count;

            //Display First Article 
            if (mostViewedPostCounter - index >= 1)
            {
                firstMVIDHolderTextBox.Text = mostViewedPostsList[index].ArticleID.ToString();
                firstMVViewerHolderTextBox.Text = mostViewedPostsList[index].ArticleViewer.ToString();
                mostViewedPostsTitleLabel1.Text = mostViewedPostsList[index].ArticleTitle;
                mostViewedPostsDateLabel1.Text = mostViewedPostsList[index].ArticleDate;
                mostViewedPostsAuthorLabel1.Text = "Author: " + mostViewedPostsList[index].ArticleAuthor;

                string tempDesc1 = mostViewedPostsList[0].ArticleDescription;
                string tempDesc2 = "";
                for (int i = 0; i < tempDesc1.Length; i++)
                {
                    tempDesc2 += tempDesc1[i];
                    if (i > 250)
                    {
                        break;
                    }
                }
                mostViewedPostsDescriptionLabel1.Text = Server.HtmlDecode(tempDesc2) + ". . .";
            }
            else
            {
                mostViewedPostsTitleLabel1.Text = "";
                mostViewedPostsDateLabel1.Text = "";
                mostViewedPostsAuthorLabel1.Text = "";
                mostViewedPostsDescriptionLabel1.Text = "";
                firstMVReadMoreButton.Visible = false;
            }

            //Display Second Article
            if (mostViewedPostCounter - index >= 2)
            {
                secondMVIDHolderTextBox.Text = mostViewedPostsList[index + 1].ArticleID.ToString();
                secondMVViewerHolderTextBox.Text = mostViewedPostsList[index+1].ArticleViewer.ToString();
                mostViewedPostsTitleLabel2.Text = mostViewedPostsList[index + 1].ArticleTitle;
                mostViewedPostsDateLabel2.Text = mostViewedPostsList[index + 1].ArticleDate;
                mostViewedPostsAuthorLabel2.Text = "Author: " + mostViewedPostsList[index + 1].ArticleAuthor;

                string tempDesc3 = mostViewedPostsList[index + 1].ArticleDescription;
                string tempDesc4 = "";
                for (int i = 0; i < tempDesc3.Length; i++)
                {
                    tempDesc4 += tempDesc3[i];
                    if (i > 250)
                    {
                        break;
                    }
                }
                mostViewedPostsDescriptionLabel2.Text = Server.HtmlDecode(tempDesc4) + ". . .";
            }
            else
            {
                mostViewedPostsTitleLabel2.Text = "";
                mostViewedPostsDateLabel2.Text = "";
                mostViewedPostsAuthorLabel2.Text = "";
                mostViewedPostsDescriptionLabel2.Text = "";
                secondMVReadMoreButton.Visible = false;
            }

            //Display Third Article
            if (mostViewedPostCounter - index >= 3)
            {
                thirdMVIDHolderTextBox.Text = mostViewedPostsList[index + 2].ArticleID.ToString();
                thirdMVViewerHolderTextBox.Text = mostViewedPostsList[index + 2].ArticleViewer.ToString();
                mostViewedPostsTitleLabel3.Text = mostViewedPostsList[index + 2].ArticleTitle;
                mostViewedPostsDateLabel3.Text = mostViewedPostsList[index + 2].ArticleDate;
                mostViewedPostsAuthorLabel3.Text = "Author: " + mostViewedPostsList[index + 2].ArticleAuthor;

                string tempDesc5 = mostViewedPostsList[index + 2].ArticleDescription;
                string tempDesc6 = "";
                for (int i = 0; i < tempDesc5.Length; i++)
                {
                    tempDesc6 += tempDesc5[i];
                    if (i > 250)
                    {
                        break;
                    }
                }
                mostViewedPostsDescriptionLabel3.Text = Server.HtmlDecode(tempDesc6) + ". . .";
            }
            else
            {
                mostViewedPostsTitleLabel3.Text = "";
                mostViewedPostsDateLabel3.Text = "";
                mostViewedPostsAuthorLabel3.Text = "";
                mostViewedPostsDescriptionLabel3.Text = "";
                thirdMVReadMoreButton.Visible = false;
            }

            //Display Fourth Article
            if (mostViewedPostCounter - index >= 4)
            {
                fourthMVIDHolderTextBox.Text = mostViewedPostsList[index + 3].ArticleID.ToString();
                fourthMVViewerHolderTextBox.Text = mostViewedPostsList[index + 3].ArticleViewer.ToString();
                mostViewedPostsTitleLabel4.Text = mostViewedPostsList[index + 3].ArticleTitle;
                mostViewedPostsDateLabel4.Text = mostViewedPostsList[index + 3].ArticleDate;
                mostViewedPostsAuthorLabel4.Text = "Author: " + mostViewedPostsList[index + 3].ArticleAuthor;

                string tempDesc7 = mostViewedPostsList[index + 3].ArticleDescription;
                string tempDesc8 = "";
                for (int i = 0; i < tempDesc7.Length; i++)
                {
                    tempDesc8 += tempDesc7[i];
                    if (i > 250)
                    {
                        break;
                    }
                }
                mostViewedPostsDescriptionLabel4.Text = Server.HtmlDecode(tempDesc8) + ". . .";
            }
            else
            {
                mostViewedPostsTitleLabel4.Text = "";
                mostViewedPostsDateLabel4.Text = "";
                mostViewedPostsAuthorLabel4.Text = "";
                mostViewedPostsDescriptionLabel4.Text = "";
                fourthMVReadMoreButton.Visible = false;
            }
        } 

        protected void firstReadMoreButton_Click(object sender, EventArgs e)
        {
            VisitorCounter(Convert.ToInt32(firstIDHolderTextBox.Text), Convert.ToInt32(firstViewerHolderTextBox.Text));
            Response.Redirect("ArticleDetails.aspx?SelectedArticleID=" + Server.UrlEncode(firstIDHolderTextBox.Text) + "& SelectedArticleViewer=" + Server.UrlEncode(firstViewerHolderTextBox.Text));
        }

        protected void secondReadMoreButton_Click(object sender, EventArgs e)
        {
            VisitorCounter(Convert.ToInt32(secondIDHolderTextBox.Text), Convert.ToInt32(secondViewerHolderTextBox.Text));
            Response.Redirect("ArticleDetails.aspx?SelectedArticleID=" + Server.UrlEncode(secondIDHolderTextBox.Text) + "& SelectedArticleViewer=" + Server.UrlEncode(secondViewerHolderTextBox.Text));
        }

        protected void thirdReadMoreButton_Click(object sender, EventArgs e)
        {
            VisitorCounter(Convert.ToInt32(thirdIDHolderTextBox.Text), Convert.ToInt32(thirdViewerHolderTextBox.Text));
            Response.Redirect("ArticleDetails.aspx?SelectedArticleID=" + Server.UrlEncode(thirdIDHolderTextBox.Text) + "& SelectedArticleViewer=" + Server.UrlEncode(thirdViewerHolderTextBox.Text));
        }

        protected void fourthReadMoreButton_Click(object sender, EventArgs e)
        {
            VisitorCounter(Convert.ToInt32(fourthIDHolderTextBox.Text), Convert.ToInt32(fourthViewerHolderTextBox.Text));
            Response.Redirect("ArticleDetails.aspx?SelectedArticleID=" + Server.UrlEncode(fourthIDHolderTextBox.Text) + "& SelectedArticleViewer=" + Server.UrlEncode(fourthViewerHolderTextBox.Text));
        }

        protected void firstMVReadMoreButton_Click(object sender, EventArgs e)
        {
            VisitorCounter(Convert.ToInt32(firstMVIDHolderTextBox.Text), Convert.ToInt32(firstMVViewerHolderTextBox.Text));
            Response.Redirect("ArticleDetails.aspx?SelectedArticleID=" + Server.UrlEncode(firstMVIDHolderTextBox.Text) + "& SelectedArticleViewer=" + Server.UrlEncode(firstMVViewerHolderTextBox.Text));
        }

        protected void secondMVReadMoreButton_Click(object sender, EventArgs e)
        {
            VisitorCounter(Convert.ToInt32(secondMVIDHolderTextBox.Text), Convert.ToInt32(secondMVViewerHolderTextBox.Text));
            Response.Redirect("ArticleDetails.aspx?SelectedArticleID=" + Server.UrlEncode(secondMVIDHolderTextBox.Text) + "& SelectedArticleViewer=" + Server.UrlEncode(secondMVViewerHolderTextBox.Text));
        }

        protected void thirdMVReadMoreButton_Click(object sender, EventArgs e)
        {
            VisitorCounter(Convert.ToInt32(thirdMVIDHolderTextBox.Text), Convert.ToInt32(thirdMVViewerHolderTextBox.Text));
            Response.Redirect("ArticleDetails.aspx?SelectedArticleID=" + Server.UrlEncode(thirdMVIDHolderTextBox.Text) + "& SelectedArticleViewer=" + Server.UrlEncode(thirdMVViewerHolderTextBox.Text));
        }

        protected void fourthMVReadMoreButton_Click(object sender, EventArgs e)
        {
            VisitorCounter(Convert.ToInt32(fourthMVIDHolderTextBox.Text), Convert.ToInt32(fourthMVViewerHolderTextBox.Text));
            Response.Redirect("ArticleDetails.aspx?SelectedArticleID=" + Server.UrlEncode(fourthMVIDHolderTextBox.Text) + "& SelectedArticleViewer=" + Server.UrlEncode(fourthMVViewerHolderTextBox.Text));
        }

        public void VisitorCounter(int selectedID, int viewer)
        {
            string connectionString = WebConfigurationManager.ConnectionStrings["CodeMastersFirstBlogConnectionString"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "UPDATE tbl_article SET article_viewer='" + (viewer + 1) + "' WHERE article_id='" + selectedID+"'";

            //Execute query
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            int rowAffected = command.ExecuteNonQuery();
            connection.Close();

            if (rowAffected > 0)
            {
                
            }
        }
    }

}