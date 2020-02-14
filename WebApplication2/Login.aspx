<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication2.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />

    <title></title>
    <link href="~/favicon.ico" rel="shortcut icon" type="image/x-icon" />
    <link href="~/Content/Login.css" rel="stylesheet" />
    <link href="~/Content/bootstrap.css" rel="stylesheet" />
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/jquery-3.4.1.min.js"></script>
    
</head>
<body>
        <div class="sidenav">
            <div class="login-main-text">
                <h2>
                    IRIXI<br/>
                    MFG Data System</h2>
                <p>Powered by Automation Team</p>
            </div>
        </div>
        <div class="main">
            <div class="col-md-6 col-sm-12">
                <div class="login-form">
                    <form id="form1" runat="server">
                        <div class="form-group">
                            <label>User Name</label>
                            <input type="text" class="form-control" placeholder="User Name"/>
                        </div>
                        <div class="form-group">
                            <label>Password</label>
                            <input type="password" class="form-control" placeholder="Password"/>
                        </div>
                        <button type="submit" class="btn btn-black">Login</button>
                        <button type="submit" class="btn btn-secondary">Register</button>
                    </form>
                </div>
            </div>
        </div>
</body>
</html>
