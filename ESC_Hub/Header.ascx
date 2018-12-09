<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Header.ascx.cs" Inherits="Header" %>

<nav class="navbar navbar-inverse navbar-fixed-top">
    <div class="container-fluid">
        <div class="navbar-header">
            <button type="button" class="navbar-toggle" data-toggle="collapse" data-target="#myNavbar">
                <span class="icon-bar"></span>
                <span class="icon-bar"></span>
                <span class="icon-bar"></span>
            </button>
            <a class="navbar-brand" href="../Default.aspx">Home</a>
        </div>
        <div class="collapse navbar-collapse" id="myNavbar">
            <ul class="nav navbar-nav">
                <li></li>
                <li class="dropdown">
                    <a href="#" class="dropdown-toggle" data-toggle="dropdown">Rankings<span class="caret"></span></a>
                    <ul class="dropdown-menu" role="menu">
                        <li><a href="../Rankings/MeleeRankings.aspx">Rankings/MeleeRankings.aspx</a></li>
                        <li><a href="../Rankings/PMRankings.aspx">Rankings/PMRankings.aspx</a></li>
                        <li><a href="../Rankings/S4Rankings.aspx">Rankings/S4Rankings.aspx</a></li>
                    </ul>
                </li>
                <li><a href="../Admin/UpdateRankings.aspx" visible="false">Admin/UpdateRankings.aspx</a></li>
                <li><a href="../Admin/EditPlayer.aspx" visible="false">Admin/EditPlayer.aspx</a></li>
            </ul>

            <ul class="nav navbar-nav navbar-right">
                <li class="dropdown">
                    <a href="#" class="dropdown-toggle" data-toggle="dropdown"><b>Login</b> <span class="caret"></span></a>
                    <ul id="login-dp" class="dropdown-menu">
                        <li>
                            <div class="row">
                                <div class="col-md-12">
                                    <%--<form class="form" role="form" method="post" action="login" accept-charset="UTF-8" id="login-nav">
                                        <div class="form-group">
                                            <label class="sr-only" for="login_username">Username</label>
                                            <input type="text" class="form-control" id="login_username" placeholder="Username">
                                        </div>
                                        <div class="form-group">
                                            <label class="sr-only" for="login_password">Password</label>
                                            <input type="password" class="form-control" id="login_password" placeholder="Password">
                                        </div>
                                        <div class="form-group">
                                            <button type="submit" class="btn btn-primary btn-block">Sign in</button>
                                        </div>
                                        <div class="checkbox">
                                            <label>
                                                <input type="checkbox">
                                                keep me logged-in											
                                            </label>
                                        </div>
                                    </form>--%>
                                </div>
                            </div>
                        </li>
                    </ul>
                </li>
            </ul>
        </div>
    </div>
</nav>
