<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Auth.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="/css/style.css" rel="stylesheet" />
    <title>Login | EdCourse </title>
    
</head>
<body>
    <nav class="navbar navbar-expand-lg navbar-light bg-light fixed-tops">
        <a class="navbar-brand">EdCourse</a>
        <button class="navbar-toggler" data-target="#my-nav" data-toggle="collapse" aria-controls="my-nav" aria-expanded="false" aria-label="Toggle navigation">
            <span class="navbar-toggler-icon"></span>
        </button>
        
    </nav>
    <div class="container w-50 my-5 mx-auto shadow-lg border rounded-full d-flex flex-column flex-md-row">
        <!-- first div -->
        <div class="p-0 d-none d-md-block my-auto w-100">
            <img src="/img/undraw_Welcome_re_h3d9.png" alt="welcome image" class="img-fluid "/>
        </div>
        <!-- second div -->
        <div class="px-3 py-5 w-100 d-flex flex-column">
            <div class="mb-2 text-center">
                <h3>Welcome back!</h3>
                <br/>
                <h5>Login to continue to EdCourse</h5>
            </div>
            <form id="loginForm" class="is-validated" runat="server">
                <div class="form-group">
                    <label for="textEmail">Email</label>
                    <asp:TextBox ID="txtEmail" CssClass="form-control" Required="True" placeholder="eg. jksmith@gmail.com" TextMode="Email" runat="server"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label for="txtPass">Password</label>
                    <asp:TextBox ID="txtPass" CssClass="form-control" Required="True" placeholder="Your Password" TextMode="Password" runat="server"></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:Button ID="btnLogin" Text="Login" CssClass="btn btn-block btn-main" runat="server" OnClick="btnLogin_Click1"></asp:Button>
                </div>

                <div class="form-group">
                    <asp:Hyperlink ID="link1" Text="New Here? Create an Account" CssClass="btn btn-block btn-default border text-primary" runat="server" NavigateUrl="~/signup.aspx"></asp:Hyperlink>
                </div>
                <div class="form-group text-center">
                    <asp:Label ID="lblStat" Text="" runat="server" cssClass="alert alert-danger p-2 text-center d-block"></asp:Label>
                </div>
            </form>
        </div>
    </div>


    <!-- scripts -->
    <script src="/js/bootstrap.min.js"></script>
    <script src="/js/jquery-3.5.1.min.js"></script>
</body>
</html>
