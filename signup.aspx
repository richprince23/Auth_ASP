<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="signup.aspx.cs" Inherits="Auth.signup" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="/css/style.css" rel="stylesheet" />
    <title>Sign Up | EdCourse </title>
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
            <img src="/img/undraw_Account_re_o7id.png" alt="welcome image" class="img-fluid "/>
        </div>
        <!-- second div -->
        <div class="px-3 py-5 w-100 d-flex flex-column">
            <div class="mb-2 text-center">
                <h3>Welcome to EdCourse</h3>
                <br/>
                <h5>Create a New Account</h5>
            </div>
            <form id="signupForm" class="form" runat="server">
                <div class="form-group">
                    <asp:Label Text="Fullname" runat="server"></asp:Label>
                    <asp:TextBox ID="txtFullname" runat="server" Required="True" placeholder="eg. John Kweku Smith" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:Label Text="Email Address" runat="server"></asp:Label>
                    <asp:TextBox ID="txtEmail" runat="server" Required="True" placeholder="eg. jksmith@gmail.com" CssClass="form-control" textMode="Email"></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:Label Text="Phone Number" runat="server"></asp:Label>
                    <asp:TextBox ID="txtPhone" runat="server" Required="True" placeholder="eg. 0242728115" CssClass="form-control"  pattern="^[0-9]{10}$" MaxLength="10" ></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:Label Text="Password" runat="server"></asp:Label>
                    <asp:TextBox ID="txtPass" runat="server" Required="True" placeholder="eg. Choose a password" CssClass="form-control" TextMode="Password"></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:Label Text="Confirm Password" runat="server"></asp:Label>
                    <asp:TextBox ID="txtPassCf" runat="server" Required="True" placeholder="eg. Enter same password again" CssClass="form-control" TextMode="Password"></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:Button Text="Sign Up" ID="btnSignup" runat="server" CssClass="btn btn-block btn-main" OnClick="btnSignup_Click"></asp:Button>
                </div>
                <div class="form-group">
                    <asp:Hyperlink ID="link1" Text="Have an account? Log In" CssClass="btn btn-block btn-default border text-primary" runat="server" NavigateUrl="~/login.aspx"></asp:Hyperlink>
                </div>
                <div class="form-group">
                    <asp:Label ID="lblStat" runat="server" cssClass="alert alert-danger d-block p-2 text-center" Visible="False"></asp:Label>
                </div>
            </form>
        </div>
</body>
</html>
