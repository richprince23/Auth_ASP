<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="dashboard.aspx.cs" Inherits="Auth.dashboard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="/css/style.css" rel="stylesheet" />
    <title>Dashboard | EdCourse</title>
</head>
<body>
    <nav class="navbar navbar-expand-lg navbar-light bg-light fixed-tops">
        <a class="navbar-brand">EdCourse</a>
        <button class="navbar-toggler" data-target="#my-nav" data-toggle="collapse" aria-controls="my-nav" aria-expanded="false" aria-label="Toggle navigation">
            <span class="navbar-toggler-icon"></span>
        </button>
        <div id="my-nav" class="collapse navbar-collapse">
            <ul class="navbar-nav mr-auto">
                <li class="nav-item active">
                    <a class="nav-link" href="#">Home<span class="sr-only"></span></a>
                </li>
                <li class="nav-item ">
                    <a class="nav-link" href="#">Courses<span class="sr-only"></span></a>
                </li>
                <li class="nav-item ">
                    <a class="nav-link" href="#">Assignments<span class="sr-only"></span></a>
                </li>
                <li class="nav-item ">
                    <a class="nav-link" href="#">Grades<span class="sr-only"></span></a>
                </li>
                
            </ul>
            <p class=" p-3 mr-3"><%= Session["email"] %></p>
            <a href="/login.aspx" class="btn btn-main">Logout</a>
        </div>
    </nav>
    <form id="form1" runat="server">
    <div class="jumbotron">
        <h1 class="display-4 text-center">Welcome to EdCourse</h1>
        <p class="lead"><%= DateTime.Now %></p>
        <hr class="my-4">
        <p>Content</p>
    </div>
    </form>
</body>
</html>
