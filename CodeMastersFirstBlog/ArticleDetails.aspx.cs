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
        int index = 0;
        private int counter = 0;
        private int currentArticleID = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            string ID = Server.UrlDecode(Request.QueryString["SelectedArticleID"]);
            currentArticleID = Convert.ToInt32(ID);
            GetComments(currentArticleID);
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
            selectedPostsDescriptionLabel.Text = Server.HtmlDecode(anArticleData.ArticleDescription);

            GetComments(currentArticleID);
        }

        private void GetComments(int id)
        {
            string connectionString = WebConfigurationManager.ConnectionStrings["CodeMastersFirstBlogConnectionString"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT * FROM tbl_comment WHERE article_id='" + id + "'";

            //Execute query
            SqlCommand command = new SqlCommand(query, connection);

            //Read data from database 
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            List<CommentRead> commentList = new List<CommentRead>();
            while (reader.Read())
            {
                CommentRead aCommentRead = new CommentRead();

                aCommentRead.CommentID = Convert.ToInt32(reader["comment_id"]);
                aCommentRead.CommentBy = reader["comment_by"].ToString();
                aCommentRead.Comment = reader["comment"].ToString();
                aCommentRead.CommentDateTime = reader["comment_date_time"].ToString();
                aCommentRead.CommentArticleID = Convert.ToInt32(reader["article_id"]);
                commentList.Add(aCommentRead);
            }
            reader.Close();

            connection.Close();

            counter = commentList.Count;

            //Viewed Comment Counting
            if (counter >= 8)
            {
                if (counter > 8 && counter <= 16)
                {
                    numberOfCommentViewedLabel.Text = "Comments " + ((counter - index) + index).ToString() + " of " + counter.ToString();
                }
                else
                {
                    numberOfCommentViewedLabel.Text = "Comments " + (8 + index).ToString() + " of " + counter.ToString();
                }
            }
            else
            {
                numberOfCommentViewedLabel.Text = "Comments " + counter.ToString() + " of " + counter.ToString();
            }

            //Display First Comment 
            if (counter - index >= 1)
            {
                commentByLabel1.Text = commentList[index].CommentBy;
                commentDateTimeLabel1.Text = commentList[index].CommentDateTime;
                commentTextBox1.Text = commentList[index].Comment;
            }
            else
            {
                commentByLabel1.Text = "";
                commentDateTimeLabel1.Text = "";
                commentTextBox1.Visible = false;
            }

            //Display Second Comment
            if (counter - index >= 2)
            {
                commentByLabel2.Text = commentList[index+1].CommentBy;
                commentDateTimeLabel2.Text = commentList[index+1].CommentDateTime;
                commentTextBox2.Text = commentList[index+1].Comment;
            }
            else
            {
                commentByLabel2.Text = "";
                commentDateTimeLabel2.Text = "";
                commentTextBox2.Visible = false;
            }

            //Display Third Comment
            if (counter - index >= 3)
            {
                commentByLabel3.Text = commentList[index + 2].CommentBy;
                commentDateTimeLabel3.Text = commentList[index + 2].CommentDateTime;
                commentTextBox3.Text = commentList[index + 2].Comment;
            }
            else
            {
                commentByLabel3.Text = "";
                commentDateTimeLabel3.Text = "";
                commentTextBox3.Visible=false;
            }

            //Display Fourth Comment
            if (counter - index >= 4)
            {
                commentByLabel4.Text = commentList[index + 3].CommentBy;
                commentDateTimeLabel4.Text = commentList[index + 3].CommentDateTime;
                commentTextBox4.Text = commentList[index + 3].Comment;
            }
            else
            {
                commentByLabel4.Text = "";
                commentDateTimeLabel4.Text = "";
                commentTextBox4.Visible = false;
            }

            //Display Fifth Comment
            if (counter - index >= 5)
            {
                commentByLabel5.Text = commentList[index + 4].CommentBy;
                commentDateTimeLabel5.Text = commentList[index + 4].CommentDateTime;
                commentTextBox5.Text = commentList[index + 4].Comment;
            }
            else
            {
                commentByLabel5.Text = "";
                commentDateTimeLabel5.Text = "";
                commentTextBox5.Visible = false;
            }

            //Display Sixth Comment
            if (counter - index >= 6)
            {
                commentByLabel6.Text = commentList[index + 5].CommentBy;
                commentDateTimeLabel6.Text = commentList[index + 5].CommentDateTime;
                commentTextBox6.Text = commentList[index + 5].Comment;
            }
            else
            {
                commentByLabel6.Text = "";
                commentDateTimeLabel6.Text = "";
                commentTextBox6.Visible = false;
            }

            //Display Seventh Comment
            if (counter - index >= 7)
            {
                commentByLabel7.Text = commentList[index + 6].CommentBy;
                commentDateTimeLabel7.Text = commentList[index + 6].CommentDateTime;
                commentTextBox7.Text = commentList[index + 6].Comment;
            }
            else
            {
                commentByLabel7.Text = "";
                commentDateTimeLabel7.Text = "";
                commentTextBox7.Visible = false;
            }

            //Display Eight Comment
            if (counter - index >= 8)
            {
                commentByLabel8.Text = commentList[index + 7].CommentBy;
                commentDateTimeLabel8.Text = commentList[index + 7].CommentDateTime;
                commentTextBox8.Text = commentList[index + 7].Comment;
            }
            else
            {
                commentByLabel8.Text = "";
                commentDateTimeLabel8.Text = "";
                commentTextBox8.Visible = false;
            }
        }

        //protected void seePreviousCommentsButton_Click(object sender, EventArgs e)
        //{
        //    if (index>=8)
        //    {
        //        index -= 8;
        //        GetComments(currentArticleID);
        //    }
        //}

        protected void seeMoreCommentsButton_Click(object sender, EventArgs e)
        {
            if ((counter - index >= 8))
            {
                if ((counter - index < 8))
                {
                    index += (counter - index);
                    GetComments(currentArticleID);
                }
                else if (counter - index > 8)
                {
                    index += 8;
                    GetComments(currentArticleID);
                }
                else
                {
                    seeMoreCommentsButton.Enabled = false;
                }
            }
        }

        protected void createNewCommentButton_Click(object sender, EventArgs e)
        {
            string commentBy = newCommentByTextBox.Text;
            string commentBody = createNewCommentTextBox.Text;

            CommentWrite aComment = new CommentWrite(commentBy, commentBody);

            if (AddComment(aComment))
            {
                Label1.Text = "Comment is added successfully!";
            }
            else
            {
                Label1.Text = "oops!";
            }

            Response.Redirect("ArticleDetails.aspx?SelectedArticleID=" + Server.UrlEncode(currentArticleID.ToString()));
            //GetArticleDetails(currentArticleID);
        }

        private bool AddComment(CommentWrite aComment)
        {
            string connectionString = WebConfigurationManager.ConnectionStrings["CodeMastersFirstBlogConnectionString"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);

            DateTime dateTime = DateTime.Now;

            //Write insert query
            string query = "INSERT INTO tbl_comment (comment_by,comment,comment_date_time, article_id) VALUES('" + aComment.CommentBy + "','" + aComment.CommentBody + "','" + DateTime.Now + "','" + currentArticleID + "')";

            //Execute query
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            int rowAffected = command.ExecuteNonQuery();
            connection.Close();

            return rowAffected > 0;
        }
        
    }

}