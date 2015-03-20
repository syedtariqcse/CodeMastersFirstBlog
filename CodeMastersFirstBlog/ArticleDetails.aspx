<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ArticleDetails.aspx.cs" Inherits="CodeMastersFirstBlog.ArticleDetails" ValidateRequest="false" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no">
    <title>Article Details </title>
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <link href="Content/bootstrap-theme.min.css" rel="stylesheet" />
    <link rel="stylesheet" href="//maxcdn.bootstrapcdn.com/font-awesome/4.3.0/css/font-awesome.min.css">
    <link href="Content/style1.css" rel="stylesheet" />
    <link rel="icon" type="image/png" href="favicon/ProjectOneFavicon.png">
</head>

<body>
    <form id="form1" runat="server">
        <div class="container">

            <div class="row">
                <div class="col-xs-offset-11 col-sm-offset-11 col-md-offset-11 col-lg-offset-11 col-xs-1 col-sm-1 col-md-1 col-lg-1 button-customize">
                    <div class="row">
                        <div class="col-xs-12 col-sm-12 col-md-12 col-lg-12">
                            <button type="button" class="btn btn-default pull-right" style="background: gold; color: black">Bangla</button>
                        </div>
                    </div>
                </div>
            </div>

            <div class="row">
                <div class="col-xs-12 col-sm-12 col-md-12 col-lg-12 headerSection">
                    <h1 style="color: gold; margin-top: 0px;">
                        <i class="fa fa-hacker-news fa-4x"></i>ellow Coders Blog. . .
                    </h1>
                </div>
            </div>
            <div class="row">
                <div class="col-xs-9 col-sm-9 col-md-9 col-lg-9 menuBarProperty">
                    <div class="row">
                        <div class="col-xs-12 col-sm-12 col-md-12 col-lg-12">
                            <nav class="navbar navbar-default" style="background: gold;">
                                <div class="container-fluid">
                                    <!-- Brand and toggle get grouped for better mobile display -->
                                    <div class="navbar-header" style="background: gold; color: black;">
                                        <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#bs-example-navbar-collapse-1">
                                            <span class="sr-only">Toggle navigation</span>
                                            <span class="icon-bar"></span>
                                            <span class="icon-bar"></span>
                                            <span class="icon-bar"></span>
                                        </button>
                                        <li>
                                            <asp:HyperLink ID="HomeOnArticleDetailsHyperLink" NavigateUrl="Default.aspx" class="navbar-brand" Style="color: black;" runat="server">Home</asp:HyperLink></li>
                                    </div>
                                    <!-- Collect the nav links, forms, and other content for toggling -->
                                    <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-1">
                                        <ul class="nav navbar-nav">
                                            <li>
                                                <asp:HyperLink ID="WriteArticleOnArticleDetailsHyperLink" NavigateUrl="WriteBlog.aspx" Style="background: gold; color: black;" runat="server">Write Article</asp:HyperLink></li>
                                            <li>
                                                <asp:HyperLink ID="CSharpOnArticleDetailsHyperLink" NavigateUrl="ArticleDetails.aspx" Style="background: gold; color: black;" runat="server">C#</asp:HyperLink></li>
                                            <li>
                                                <asp:HyperLink ID="ASPDOTNETOnArticleDetailsHyperLink" NavigateUrl="ArticleDetails.aspx" Style="background: gold; color: black;" runat="server">ASP.NET</asp:HyperLink></li>
                                            <li>
                                                <asp:HyperLink ID="HTML5OnArticleDetailsHyperLink" NavigateUrl="ArticleDetails.aspx" Style="background: gold; color: black;" runat="server">HTML5</asp:HyperLink></li>
                                            <li>
                                                <asp:HyperLink ID="CSSOnArticleDetailsHyperLink" NavigateUrl="ArticleDetails.aspx" Style="background: gold; color: black;" runat="server">CSS</asp:HyperLink></li>
                                            <li>
                                                <asp:HyperLink ID="BootstrapOnArticleDetailsHyperLink" NavigateUrl="ArticleDetails.aspx" Style="background: gold; color: black;" runat="server">Bootstrap</asp:HyperLink></li>
                                            <li>
                                                <asp:HyperLink ID="JavaScriptOnArticleDetailsHyperLink" NavigateUrl="ArticleDetails.aspx" Style="background: gold; color: black;" runat="server">JavaScript</asp:HyperLink></li>
                                            <%-- <li><asp:HyperLink ID="GitHubOnWriteArticleHyperLink" NavigateUrl="WriteBlog.aspx" style="background: gold; color: black;" runat="server">GitHub</asp:HyperLink></li>--%>
                                        </ul>
                                        <%--<form id="form2" class="navbar-form navbar-left" role="search">
                                    <div class="form-group">
                                        <input type="text" class="form-control" placeholder="Search">
                                    </div>
                                    <button type="submit" class="btn btn-default" style="background: black; color: gold">Search</button>
                                </form>--%>
                                        <%--<asp:FormView ID="FormView1" runat="server">--%>

                                        <%--</asp:FormView>--%>

                                        <ul class="nav navbar-nav navbar-right">
                                            <li><a href="#" style="background: gold; color: black;">Angular Js</a></li>

                                            <li><a href="#" style="background: gold; color: black;">About us</a></li>
                                        </ul>
                                    </div>
                                    <!-- /.navbar-collapse -->
                                </div>
                                <!-- /.container-fluid -->
                            </nav>
                        </div>
                    </div>
                </div>
                <div class="col-xs-3 col-sm-3 col-md-3 col-lg-3 socialNetworkIconBar" style="padding-bottom: 4px; padding-right: 5px;">
                    <span class="pull-right">
                        <a href="https://www.facebook.com" style="margin-right: 5px"><i class="fa fa-facebook-official fa-4x" style="color: gold"></i></a>
                        <a href="https://www.twitter.com" style="margin-right: 5px"><i class="fa fa-twitter-square fa-4x" style="color: gold"></i></a>
                        <a href="https://plus.google.com" style="margin-right: 5px"><i class="fa fa-google-plus-square fa-4x" style="color: gold"></i></a>
                        <a href="https://www.linkedin.com" style="margin-right: 5px"><i class="fa fa-linkedin-square fa-4x" style="color: gold"></i></a>
                    </span>
                </div>
            </div>

            <div class="row">
                <div class="col-xs-9 col-sm-9 col-md-9 col-lg-9">
                    <div class="row">
                        <div class="col-xs-12 col-sm-12 col-md-12 col-lg-12">
                            <blockquote>
                                <%--<asp:HyperLink ID="NewPostsOnHomeHyperLink" NavigateUrl="Default.aspx" Style="color: black;" runat="server"><h2>New Posts</h2></asp:HyperLink>--%>
                                <h3>
                                    <asp:Label ID="selectedPostsTitleLabel" runat="server" Text="Label"></asp:Label></h3>
                                <br />
                                <asp:TextBox ID="IDReceiverTextBox" runat="server" Visible="False" Text=""></asp:TextBox>
                                <footer>
                                    <cite title="Source Title">
                                        <i>
                                            <asp:Label ID="selectedPostsDateLabel" runat="server" Text="Label"></asp:Label></i><br />
                                    </cite>
                                    Author:
                            <asp:Label ID="selectedPostsAuthorLabel" runat="server" Text="Label"></asp:Label>
                                </footer>
                            </blockquote>
                            <asp:Label ID="selectedPostsDescriptionLabel" runat="server" Text="Label"></asp:Label><br />
                        </div>
                    </div>
                    <%------------------Comment Section Starts Here----------------------------------------------%>
                    <div class="row">
                        <div class="col-xs-12 col-sm-12 col-md-12 col-lg-12">
                            <div class="form-group">
                                <%--------------------------Show Comments Section---------------------------------%>
                                <asp:Label ID="commentByLabel1" runat="server" Text="Label"></asp:Label>
                                <asp:Label ID="commentDateTimeLabel1" runat="server" Text="Label"></asp:Label><br />
                                <asp:TextBox ID="commentTextBox1" TextMode="MultiLine" CssClass="form-control commentBoxProperty" runat="server"></asp:TextBox><br />

                                <asp:Label ID="commentByLabel2" runat="server" Text="Label"></asp:Label>
                                <asp:Label ID="commentDateTimeLabel2" runat="server" Text="Label"></asp:Label><br />
                                <asp:TextBox ID="commentTextBox2" TextMode="MultiLine" CssClass="form-control commentBoxProperty" runat="server"></asp:TextBox><br />

                                <asp:Label ID="commentByLabel3" runat="server" Text="Label"></asp:Label>
                                <asp:Label ID="commentDateTimeLabel3" runat="server" Text="Label"></asp:Label><br />
                                <asp:TextBox ID="commentTextBox3" TextMode="MultiLine" CssClass="form-control commentBoxProperty" runat="server"></asp:TextBox><br />

                                <asp:Label ID="commentByLabel4" runat="server" Text="Label"></asp:Label>
                                <asp:Label ID="commentDateTimeLabel4" runat="server" Text="Label"></asp:Label>
                                <asp:TextBox ID="commentTextBox4" TextMode="MultiLine" CssClass="form-control commentBoxProperty" runat="server"></asp:TextBox><br />

                                <asp:Label ID="commentByLabel5" runat="server" Text="Label"></asp:Label>
                                <asp:Label ID="commentDateTimeLabel5" runat="server" Text="Label"></asp:Label>
                                <asp:TextBox ID="commentTextBox5" TextMode="MultiLine" CssClass="form-control commentBoxProperty" runat="server"></asp:TextBox><br />

                                <asp:Label ID="commentByLabel6" runat="server" Text="Label"></asp:Label>
                                <asp:Label ID="commentDateTimeLabel6" runat="server" Text="Label"></asp:Label>
                                <asp:TextBox ID="commentTextBox6" TextMode="MultiLine" CssClass="form-control commentBoxProperty" runat="server"></asp:TextBox><br />

                                <asp:Label ID="commentByLabel7" runat="server" Text="Label"></asp:Label>
                                <asp:Label ID="commentDateTimeLabel7" runat="server" Text="Label"></asp:Label>
                                <asp:TextBox ID="commentTextBox7" TextMode="MultiLine" CssClass="form-control commentBoxProperty" runat="server"></asp:TextBox><br />

                                <asp:Label ID="commentByLabel8" runat="server" Text="Label"></asp:Label>
                                <asp:Label ID="commentDateTimeLabel8" runat="server" Text="Label"></asp:Label>
                                <asp:TextBox ID="commentTextBox8" TextMode="MultiLine" CssClass="form-control commentBoxProperty" runat="server"></asp:TextBox><br />

                                <div align="center" style="color: black;">
                                    <b>
                                        <asp:Label ID="numberOfCommentViewedLabel" runat="server" Text="Label"></asp:Label>
                                    </b>
                                </div>

                            </div>
                            <%----------------------------See More Comments Section--------------------------------------%>
                            <div class="row">
                                <div class="col-xs-12 col-sm-12 col-md-12 col-lg-12">
                                    <div align="center" style="color: gold;">
                                        <%--<asp:Button ID="seePreviousCommentsButton" runat="server" Text="<< See Previous Comments" BackColor="black" OnClick="seePreviousCommentsButton_Click" />--%>
                                        <asp:Button ID="seeMoreCommentsButton" runat="server" Text="See More Comments" BackColor="black" OnClick="seeMoreCommentsButton_Click" />
                                    </div>
                                </div>
                            </div>

                            <div class="row">
                                <div class="col-xs-12 col-sm-12 col-md-12 col-lg-12">
                                    <div align="center" style="color: black;">
                                        <br />
                                    </div>
                                </div>
                            </div>
                            <%--------------------------Create Comments Section---------------------------------%>
                            <div style="background: gainsboro">
                                <br />
                                <div class="form-group" style="margin-left: 20px; margin-right: 20px">
                                    <label for="newCommentByTextBox">Comment By: </label>
                                    <asp:TextBox ID="newCommentByTextBox" class="form-control" runat="server" placeholder="Comment by. . ."></asp:TextBox>
                                </div>
                                <div class="form-group" style="margin-left: 20px; margin-right: 20px">
                                    <label for="createNewCommentTextBox">Comment: </label>
                                    <asp:TextBox ID="createNewCommentTextBox" class="form-control" runat="server" placeholder="Enter your comment here..."></asp:TextBox>
                                </div>
                                <div align="center" style="margin-left: 20px; margin-right: 20px">
                                    <asp:Button ID="createNewCommentButton" class="btn btn-default" runat="server" Text="Comment" OnClick="createNewCommentButton_Click" />
                                    <br />
                                    <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                                    <br />
                                </div>
                            </div>

                        </div>
                    </div>

                </div>

                <div class="col-xs-3 col-sm-3 col-md-3 col-lg-3">
                    <div class="row">
                        <div class="col-xs-12 col-sm-12 col-md-12 col-lg-12" style="padding: 0px">
                            <div class="list-group rightAside">
                                <a href="#" class="list-group-item active" style="background: gold; text-align: center; color: black">C# Latest Articles 
                                </a>
                                <a href="#" class="list-group-item" style="color: black">Dapibus ac facilisis in</a>
                                <a href="#" class="list-group-item" style="color: black">Morbi leo risus</a>
                                <a href="#" class="list-group-item" style="color: black">Porta ac consectetur ac</a>
                                <a href="#" class="list-group-item" style="color: black">Vestibulum at eros</a>
                                <a href="#" class="list-group-item" style="color: black">Vestibulum at eros</a>
                            </div>
                            <div class="list-group rightAside">
                                <a href="#" class="list-group-item active" style="background: gold; text-align: center; color: black">Asp.Net Latest Articles 
                                </a>
                                <a href="#" class="list-group-item" style="color: black">Dapibus ac facilisis in</a>
                                <a href="#" class="list-group-item" style="color: black">Morbi leo risus</a>
                                <a href="#" class="list-group-item" style="color: black">Porta ac consectetur ac</a>
                                <a href="#" class="list-group-item" style="color: black">Vestibulum at eros</a>
                                <a href="#" class="list-group-item" style="color: black">Vestibulum at eros</a>
                            </div>
                            <div class="list-group rightAside">
                                <a href="#" class="list-group-item active" style="background: gold; text-align: center; color: black">JavaSript Latest Articles 
                                </a>
                                <a href="#" class="list-group-item" style="color: black">Dapibus ac facilisis in</a>
                                <a href="#" class="list-group-item" style="color: black">Morbi leo risus</a>
                                <a href="#" class="list-group-item" style="color: black">Porta ac consectetur ac</a>
                                <a href="#" class="list-group-item" style="color: black">Vestibulum at eros</a>
                                <a href="#" class="list-group-item" style="color: black">Vestibulum at eros</a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

            <%--<div class="row">
                <div class="col-xs-12 col-sm-12 col-md-12 col-lg-12 ">
                    <nav>
                        <ul class="pagination paginationProperty" style="margin-bottom: 0px; margin-top: 0px;">
                            <li class="disabled"><a href="#" aria-label="Previous"><span aria-hidden="true">&laquo;</span></a></li>
                            <li class="active"><a href="#">1 <span class="sr-only">(current)</span></a></li>
                            <li class=""><a href="#">2 <span class="sr-only">(current)</span></a></li>
                            <li class=""><a href="#">3 <span class="sr-only">(current)</span></a></li>
                            <li class=""><a href="#">4 <span class="sr-only">(current)</span></a></li>
                            <li class=""><a href="#">5 <span class="sr-only">(current)</span></a></li>
                            <li><a href="#" aria-label="Next"><span aria-hidden="true">&raquo;</span></a></li>
                        </ul>
                    </nav>
                </div>
            </div>--%>

            <footer class="row footerProperty">
                <div class="col-xs-12 col-sm-12 col-md-12 col-lg-12" style="text-align: center; color: gray">
                    Editor-in-Chief: CodeMasters<br />
                    Cell:+8801921039325, +8801744761629<br />
                    Email: <font color="">engr.syedtariqcse@gmail.com</font>
                    <br />
                    Copyright © <font color="">www.yellowcoders.com</font>2015. All Right ® reserved<br />
                </div>
            </footer>
        </div>
    </form>

    <script src="Scripts/jquery-2.1.3.js"></script>
    <script src="Scripts/bootstrap.js"></script>
</body>

</html>
