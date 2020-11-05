<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Menu.ascx.cs" Inherits="WebForms_sample2.Controls.Menu" %>
<%@ OutputCache Duration="9999999" VaryByParam="None" %>

 <div class="navbar navbar-inverse navbar-fixed-top">
            <div class="container">
                <div class="navbar-header">
                    <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                    </button>
                    <a class="navbar-brand" runat="server" href="~/">ASP.NET Samples</a>
                </div>
                <div class="navbar-collapse collapse">
                    <ul class="nav navbar-nav">
                        <li><a runat="server" href="~/">Home</a></li>
                        <li><a runat="server" href="~/DownloadFile">DownloadFile</a></li>
                        <li><a runat="server" href="~/Xml/Xml">Xml</a></li>
                        <li><a runat="server" href="~/Linq/SimpleQuery">Linq</a></li>
                        <li><a runat="server" href="~/ErrorHandling">Error Handling</a></li>
                        <li class="dropdown">
                            <a class="dropdown-toggle" href="#" id="navbarDropdown" role="button" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">Controls
                            </a>
                            <ul class="dropdown-menu" aria-labelledby="navbarDropdown">
                                <li><a runat="server" class="dropdown-item" href="~/Controls/Buttons">Buttons</a></li>
                                <li><a runat="server" class="dropdown-item" href="~/Controls/Data">Data</a></li>
                                <li><a runat="server" class="dropdown-item" href="~/Controls/Inputs">Inputs</a></li>
                                <li><a runat="server" class="dropdown-item" href="~/Controls/Panels">Panels</a></li>
                                <li><a runat="server" class="dropdown-item" href="~/Controls/Ajax">Ajax</a></li>
                                <li><a runat="server" class="dropdown-item" href="~/Controls/Validators">Validators</a></li>
                            </ul>
                        </li>
                        <li class="dropdown">
                            <a class="dropdown-toggle" href="#" id="navbarDropdown3" role="button" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">States
                            </a>
                            <ul class="dropdown-menu" aria-labelledby="navbarDropdown">
                                <li><a runat="server" class="dropdown-item" href="~/States/ViewState">ViewState</a></li>
                                <li><a runat="server" class="dropdown-item" href="~/States/SessionState">SessionState</a></li>
                                <li><a runat="server" class="dropdown-item" href="~/States/HttpCookieSample">HttpCookie</a></li>
                                <li><a runat="server" class="dropdown-item" href="~/States/CookieCollectionSample">CookieCollection</a></li>
                            </ul>
                        </li>
                    </ul>
                </div>
            </div>
        </div>