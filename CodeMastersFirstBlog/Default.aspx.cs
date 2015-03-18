﻿using System;
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
                newPostsList.Add(anArticleData);
            }
            reader.Close();

            connection.Close();

            counter = newPostsList.Count;

            //Display First Article 
            if (counter - index >= 1)
            {
                firstIDHolderTextBox.Text = newPostsList[index].ArticleID.ToString();
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
            if (counter - index >= 2)
            {
                secondIDHolderTextBox.Text = newPostsList[index + 1].ArticleID.ToString();
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