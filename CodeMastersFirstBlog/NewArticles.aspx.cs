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
    public partial class NewArticles : System.Web.UI.Page
    {
        int index = 0;
        private int counter = 0;
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
                anArticleData.ArticleViewer = Convert.ToInt32(reader["article_viewer"]);
                newPostsList.Add(anArticleData);
            }
            reader.Close();

            connection.Close();

            counter = newPostsList.Count;

            //Viewed Post Counting
            if (counter>=8)
            {
                numberOfPostViewedLabel.Text = "Posts " + (8 + index).ToString() + " of " + counter.ToString();
            }
            else
            {
                numberOfPostViewedLabel.Text = "Posts " + counter.ToString() + " of " + counter.ToString();
            }

            //Display First Article 
            if (counter - index >= 1)
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
            if (counter-index >=2)
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
            if (counter - index >= 3)
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
            if (counter - index >= 4)
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

            //Display Fifth Article
            if (counter - index >= 5)
            {
                fifthIDHolderTextBox.Text = newPostsList[index + 4].ArticleID.ToString();
                fifthViewerHolderTextBox.Text = newPostsList[index + 4].ArticleViewer.ToString();
                newPostsTitleLabel5.Text = newPostsList[index + 4].ArticleTitle;
                newPostsDateLabel5.Text = newPostsList[index + 4].ArticleDate;
                newPostsAuthorLabel5.Text = "Author: " + newPostsList[index + 4].ArticleAuthor;

                string tempDesc9 = newPostsList[index + 4].ArticleDescription;
                string tempDesc10 = "";
                for (int i = 0; i < tempDesc9.Length; i++)
                {
                    tempDesc10 += tempDesc9[i];
                    if (i > 250)
                    {
                        break;
                    }
                }
                newPostsDescriptionLabel5.Text = Server.HtmlDecode(tempDesc10) + ". . .";
            }
            else
            {
                newPostsTitleLabel5.Text = "";
                newPostsDateLabel5.Text = "";
                newPostsAuthorLabel5.Text = "";
                newPostsDescriptionLabel5.Text = "";
                fifthReadMoreButton.Visible = false;
            }

            //Display Sixth Article
            if (counter - index >= 6)
            {
                sixthIDHolderTextBox.Text = newPostsList[index + 5].ArticleID.ToString();
                sixthViewerHolderTextBox.Text = newPostsList[index + 5].ArticleViewer.ToString();
                newPostsTitleLabel6.Text = newPostsList[index + 5].ArticleTitle;
                newPostsDateLabel6.Text = newPostsList[index + 5].ArticleDate;
                newPostsAuthorLabel6.Text = "Author: " + newPostsList[index + 5].ArticleAuthor;

                string tempDesc11 = newPostsList[index + 5].ArticleDescription;
                string tempDesc12 = "";
                for (int i = 0; i < tempDesc11.Length; i++)
                {
                    tempDesc12 += tempDesc11[i];
                    if (i > 250)
                    {
                        break;
                    }
                }
                newPostsDescriptionLabel6.Text = Server.HtmlDecode(tempDesc12) + ". . .";
            }
            else
            {
                newPostsTitleLabel6.Text = "";
                newPostsDateLabel6.Text = "";
                newPostsAuthorLabel6.Text = "";
                newPostsDescriptionLabel6.Text = "";
                sixthReadMoreButton.Visible = false;
            }

            //Display Seventh Article
            if (counter - index >= 7)
            {
                seventhIDHolderTextBox.Text = newPostsList[index + 6].ArticleID.ToString();
                seventhViewerHolderTextBox.Text = newPostsList[index + 6].ArticleViewer.ToString();
                newPostsTitleLabel7.Text = newPostsList[index + 6].ArticleTitle;
                newPostsDateLabel7.Text = newPostsList[index + 6].ArticleDate;
                newPostsAuthorLabel7.Text = "Author: " + newPostsList[index + 6].ArticleAuthor;

                string tempDesc13 = newPostsList[index + 6].ArticleDescription;
                string tempDesc14 = "";
                for (int i = 0; i < tempDesc13.Length; i++)
                {
                    tempDesc14 += tempDesc13[i];
                    if (i > 250)
                    {
                        break;
                    }
                }
                newPostsDescriptionLabel7.Text = Server.HtmlDecode(tempDesc14) + ". . .";
            }
            else
            {
                newPostsTitleLabel7.Text = "";
                newPostsDateLabel7.Text = "";
                newPostsAuthorLabel7.Text = "";
                newPostsDescriptionLabel7.Text = "";
                seventhReadMoreButton.Visible = false;
            }

            //Display Eight Article
            if (counter - index >= 8)
            {
                eightIDHolderTextBox.Text = newPostsList[index + 7].ArticleID.ToString();
                eightViewerHolderTextBox.Text = newPostsList[index + 7].ArticleViewer.ToString();
                newPostsTitleLabel8.Text = newPostsList[index + 7].ArticleTitle;
                newPostsDateLabel8.Text = newPostsList[index + 7].ArticleDate;
                newPostsAuthorLabel8.Text = "Author: " + newPostsList[index + 7].ArticleAuthor;

                string tempDesc15 = newPostsList[index + 7].ArticleDescription;
                string tempDesc16 = "";
                for (int i = 0; i < tempDesc15.Length; i++)
                {
                    tempDesc16 += tempDesc15[i];
                    if (i > 250)
                    {
                        break;
                    }
                }
                newPostsDescriptionLabel8.Text = Server.HtmlDecode(tempDesc16) + ". . .";
            }
            else
            {
                newPostsTitleLabel8.Text = "";
                newPostsDateLabel8.Text = "";
                newPostsAuthorLabel8.Text = "";
                newPostsDescriptionLabel8.Text = "";
                eightReadMoreButton.Visible = false;
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

        protected void fifthReadMoreButton_Click(object sender, EventArgs e)
        {
            VisitorCounter(Convert.ToInt32(fifthIDHolderTextBox.Text), Convert.ToInt32(fifthViewerHolderTextBox.Text));
            Response.Redirect("ArticleDetails.aspx?SelectedArticleID=" + Server.UrlEncode(fifthIDHolderTextBox.Text) + "& SelectedArticleViewer=" + Server.UrlEncode(fifthViewerHolderTextBox.Text));
        }

        protected void sixthReadMoreButton_Click(object sender, EventArgs e)
        {
            VisitorCounter(Convert.ToInt32(sixthIDHolderTextBox.Text), Convert.ToInt32(sixthViewerHolderTextBox.Text));
            Response.Redirect("ArticleDetails.aspx?SelectedArticleID=" + Server.UrlEncode(sixthIDHolderTextBox.Text) + "& SelectedArticleViewer=" + Server.UrlEncode(sixthViewerHolderTextBox.Text));
        }

        protected void seventhReadMoreButton_Click(object sender, EventArgs e)
        {
            VisitorCounter(Convert.ToInt32(seventhIDHolderTextBox.Text), Convert.ToInt32(seventhViewerHolderTextBox.Text));
            Response.Redirect("ArticleDetails.aspx?SelectedArticleID=" + Server.UrlEncode(seventhIDHolderTextBox.Text) + "& SelectedArticleViewer=" + Server.UrlEncode(seventhViewerHolderTextBox.Text));
        }

        protected void eightReadMoreButton_Click(object sender, EventArgs e)
        {
            VisitorCounter(Convert.ToInt32(eightIDHolderTextBox.Text), Convert.ToInt32(eightViewerHolderTextBox.Text));
            Response.Redirect("ArticleDetails.aspx?SelectedArticleID=" + Server.UrlEncode(eightIDHolderTextBox.Text) + "& SelectedArticleViewer=" + Server.UrlEncode(eightViewerHolderTextBox.Text));
        }

        protected void seeMorePostsButton_Click(object sender, EventArgs e)
        {
            if ((counter - index >= 8))
            {
                if ((counter-index < 8))
                {
                    index += (counter-index);
                    GetNewPosts();
                }
                else if (counter - index > 8)
                {
                    index += 8;
                    GetNewPosts();
                }
                else
                {
                    seeMorePostsButton.Enabled = false;
                }
            }
        }

        public void VisitorCounter(int selectedID, int viewer)
        {
            string connectionString = WebConfigurationManager.ConnectionStrings["CodeMastersFirstBlogConnectionString"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "UPDATE tbl_article SET article_viewer='" + (viewer + 1) + "' WHERE article_id='" + selectedID + "'";

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