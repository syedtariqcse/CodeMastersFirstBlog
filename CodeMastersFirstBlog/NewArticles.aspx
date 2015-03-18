<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewArticles.aspx.cs" Inherits="CodeMastersFirstBlog.NewArticles" ValidateRequest="false" %>

<%--<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
    </form>
</body>
</html>--%>



<!DOCTYPE html>
<html>
<head runat="server">
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no">
    <title> New Articles </title>
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <link href="Content/bootstrap-theme.min.css" rel="stylesheet" />
    <link rel="stylesheet" href="//maxcdn.bootstrapcdn.com/font-awesome/4.3.0/css/font-awesome.min.css">
    <link href="Content/style1.css" rel="stylesheet" />
    <link rel="icon" type="image/png" href="favicon/ProjectOneFavicon.png">
    <script src="//tinymce.cachefly.net/4.1/tinymce.min.js"></script>
    <script>tinymce.init({ selector: 'textarea' });</script>
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
                                            <asp:HyperLink ID="HomeOnThisHyperLink" NavigateUrl="Default.aspx" class="navbar-brand" Style="color: black;" runat="server">Home</asp:HyperLink></li>
                                    </div>
                                    <!-- Collect the nav links, forms, and other content for toggling -->
                                    <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-1">
                                        <ul class="nav navbar-nav">
                                            <li>
                                                <asp:HyperLink ID="WriteArticleOnHomeHyperLink" NavigateUrl="WriteBlog.aspx" Style="background: gold; color: black;" runat="server">Write Article</asp:HyperLink></li>
                                            <li>
                                                <asp:HyperLink ID="CSharpOnHomeHyperLink" NavigateUrl="WriteBlog.aspx" Style="background: gold; color: black;" runat="server">C#</asp:HyperLink></li>
                                            <li>
                                                <asp:HyperLink ID="ASPDOTNETOnHomeHyperLink" NavigateUrl="WriteBlog.aspx" Style="background: gold; color: black;" runat="server">ASP.NET</asp:HyperLink></li>
                                            <li>
                                                <asp:HyperLink ID="HTML5OnHomeHyperLink" NavigateUrl="WriteBlog.aspx" Style="background: gold; color: black;" runat="server">HTML5</asp:HyperLink></li>
                                            <li>
                                                <asp:HyperLink ID="CSSOnHomeHyperLink" NavigateUrl="WriteBlog.aspx" Style="background: gold; color: black;" runat="server">CSS</asp:HyperLink></li>
                                            <li>
                                                <asp:HyperLink ID="BootstrapOnHomeHyperLink" NavigateUrl="WriteBlog.aspx" Style="background: gold; color: black;" runat="server">Bootstrap</asp:HyperLink></li>
                                            <li>
                                                <asp:HyperLink ID="JavaScriptOnHomeHyperLink" NavigateUrl="WriteBlog.aspx" Style="background: gold; color: black;" runat="server">JavaScript</asp:HyperLink></li>
                                            <%-- <li><asp:HyperLink ID="GitHubOnWriteArticleHyperLink" NavigateUrl="WriteBlog.aspx" style="background: gold; color: black;" runat="server">GitHub</asp:HyperLink></li>--%>
                                        </ul>
                                        <%--<form id="form2" class="navbar-form navbar-left" role="search">
                                    <div class="form-group">
                                        <input type="text" class="form-control" placeholder="Search">
                                    </div>
                                    <button type="submit" class="btn btn-default" style="background: black; color: gold">Search</button>
                                </form>--%>                                        <%--<asp:FormView ID="FormView1" runat="server">--%>
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
                    <blockquote>
                        <asp:HyperLink ID="NewPostsOnHomeHyperLink" NavigateUrl="Default.aspx" Style="color: black;" runat="server"><h2>New Posts</h2></asp:HyperLink>
                        <footer>
                            <cite title="Source Title">
                                <asp:Label ID="newPostsHeaderDateLabel" runat="server" Text="Label"></asp:Label></cite>
                        </footer>
                    </blockquote>

                    <h3>
                        <asp:Label ID="newPostsTitleLabel1" runat="server" Text="Label"></asp:Label><br />
                    </h3>
                    <span style="color: gray;"><i>
                        <asp:Label ID="newPostsDateLabel1" runat="server" Text="Label"></asp:Label></i></span><br />
                    <span style="color: gray;">
                        <asp:Label ID="newPostsAuthorLabel1" runat="server" Text="Label"></asp:Label></span><br />
                    <asp:Label ID="newPostsDescriptionLabel1" runat="server" Text="Label"></asp:Label><br />
                    <asp:TextBox ID="firstIDHolderTextBox" runat="server" Visible="False"></asp:TextBox>
                    <asp:Button ID="firstReadMoreButton" runat="server" Text="Read More" BackColor="gray" BorderStyle="None" OnClick="firstReadMoreButton_Click" />

                    <h3>
                        <asp:Label ID="newPostsTitleLabel2" runat="server" Text="Label"></asp:Label><br />
                    </h3>
                    <span style="color: gray;"><i>
                        <asp:Label ID="newPostsDateLabel2" runat="server" Text="Label"></asp:Label></i></span><br />
                    <span style="color: gray;">
                        <asp:Label ID="newPostsAuthorLabel2" runat="server" Text="Label"></asp:Label></span><br />
                    <asp:Label ID="newPostsDescriptionLabel2" runat="server" Text="Label"></asp:Label><br />
                    <asp:TextBox ID="secondIDHolderTextBox" runat="server" Visible="False"></asp:TextBox>
                    <asp:Button ID="secondReadMoreButton" runat="server" Text="Read More" BackColor="gray" BorderStyle="None" OnClick="secondReadMoreButton_Click" />

                    <h3>
                        <asp:Label ID="newPostsTitleLabel3" runat="server" Text="Label"></asp:Label><br />
                    </h3>
                    <span style="color: gray;"><i>
                        <asp:Label ID="newPostsDateLabel3" runat="server" Text="Label"></asp:Label></i></span><br />
                    <span style="color: gray;">
                        <asp:Label ID="newPostsAuthorLabel3" runat="server" Text="Label"></asp:Label></span><br />
                    <asp:Label ID="newPostsDescriptionLabel3" runat="server" Text="Label"></asp:Label><br />
                    <asp:TextBox ID="thirdIDHolderTextBox" runat="server" Visible="False"></asp:TextBox>
                    <asp:Button ID="thirdReadMoreButton" runat="server" Text="Read More" BackColor="gray" BorderStyle="None" OnClick="thirdReadMoreButton_Click" />

                    <h3>
                        <asp:Label ID="newPostsTitleLabel4" runat="server" Text="Label"></asp:Label><br />
                    </h3>
                    <span style="color: gray;"><i>
                        <asp:Label ID="newPostsDateLabel4" runat="server" Text="Label"></asp:Label></i></span><br />
                    <span style="color: gray;">
                        <asp:Label ID="newPostsAuthorLabel4" runat="server" Text="Label"></asp:Label></span><br />
                    <asp:Label ID="newPostsDescriptionLabel4" runat="server" Text="Label"></asp:Label><br />
                    <asp:TextBox ID="fourthIDHolderTextBox" runat="server" Visible="False"></asp:TextBox>
                    <asp:Button ID="fourthReadMoreButton" runat="server" Text="Read More" BackColor="gray" BorderStyle="None" OnClick="fourthReadMoreButton_Click" />


                    <h3>
                        <asp:Label ID="newPostsTitleLabel5" runat="server" Text="Label"></asp:Label><br />
                    </h3>
                    <span style="color: gray;"><i>
                        <asp:Label ID="newPostsDateLabel5" runat="server" Text="Label"></asp:Label></i></span><br />
                    <span style="color: gray;">
                        <asp:Label ID="newPostsAuthorLabel5" runat="server" Text="Label"></asp:Label></span><br />
                    <asp:Label ID="newPostsDescriptionLabel5" runat="server" Text="Label"></asp:Label><br />
                    <asp:TextBox ID="fifthIDHolderTextBox" runat="server" Visible="False"></asp:TextBox>
                    <asp:Button ID="fifthReadMoreButton" runat="server" Text="Read More" BackColor="gray" BorderStyle="None" OnClick="fifthReadMoreButton_Click" />

                    <h3>
                        <asp:Label ID="newPostsTitleLabel6" runat="server" Text="Label"></asp:Label><br />
                    </h3>
                    <span style="color: gray;"><i>
                        <asp:Label ID="newPostsDateLabel6" runat="server" Text="Label"></asp:Label></i></span><br />
                    <span style="color: gray;">
                        <asp:Label ID="newPostsAuthorLabel6" runat="server" Text="Label"></asp:Label></span><br />
                    <asp:Label ID="newPostsDescriptionLabel6" runat="server" Text="Label"></asp:Label><br />
                    <asp:TextBox ID="sixthIDHolderTextBox" runat="server" Visible="False"></asp:TextBox>
                    <asp:Button ID="sixthReadMoreButton" runat="server" Text="Read More" BackColor="gray" BorderStyle="None" OnClick="sixthReadMoreButton_Click" />

                    <h3>
                        <asp:Label ID="newPostsTitleLabel7" runat="server" Text="Label"></asp:Label><br />
                    </h3>
                    <span style="color: gray;"><i>
                        <asp:Label ID="newPostsDateLabel7" runat="server" Text="Label"></asp:Label></i></span><br />
                    <span style="color: gray;">
                        <asp:Label ID="newPostsAuthorLabel7" runat="server" Text="Label"></asp:Label></span><br />
                    <asp:Label ID="newPostsDescriptionLabel7" runat="server" Text="Label"></asp:Label><br />
                    <asp:TextBox ID="seventhIDHolderTextBox" runat="server" Visible="False"></asp:TextBox>
                    <asp:Button ID="seventhReadMoreButton" runat="server" Text="Read More" BackColor="gray" BorderStyle="None" OnClick="seventhReadMoreButton_Click" />

                    <h3>
                        <asp:Label ID="newPostsTitleLabel8" runat="server" Text="Label"></asp:Label><br />
                    </h3>
                    <span style="color: gray;"><i>
                        <asp:Label ID="newPostsDateLabel8" runat="server" Text="Label"></asp:Label></i></span><br />
                    <span style="color: gray;">
                        <asp:Label ID="newPostsAuthorLabel8" runat="server" Text="Label"></asp:Label></span><br />
                    <asp:Label ID="newPostsDescriptionLabel8" runat="server" Text="Label"></asp:Label><br />
                    <asp:TextBox ID="eightIDHolderTextBox" runat="server" Visible="False"></asp:TextBox>
                    <asp:Button ID="eightReadMoreButton" runat="server" Text="Read More" BackColor="gray" BorderStyle="None" OnClick="eightReadMoreButton_Click" />
                    <br />



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

            <div class="row">
                <div class="col-xs-12 col-sm-12 col-md-12 col-lg-12">
                    <div align="center" style="color: black;">
                        <b>
                            <asp:Label ID="numberOfPostViewedLabel" runat="server" Text="Label"></asp:Label>
                        </b>
                    </div>
                </div>
            </div>

            <div class="row">
                <div class="col-xs-12 col-sm-12 col-md-12 col-lg-12">
                    <div align="center" style="color: gold;">
                        
                        <asp:Button ID="seeMorePostsButton" runat="server" Text="See More Posts" BackColor="black" OnClick="seeMorePostsButton_Click" />
                        
                    </div>
                </div>
            </div>
            
            <div class="row">
                <div class="col-xs-12 col-sm-12 col-md-12 col-lg-12">
                    <div align="center" style="color: black;">
                        <br/>
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
