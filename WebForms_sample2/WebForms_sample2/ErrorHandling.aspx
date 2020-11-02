<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ErrorHandling.aspx.cs" Inherits="WebForms_sample2.ErrorHandling" Trace ="true"%>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
            <asp:Label ID="lblheading" runat="server" Text="Tracing, Debuggin  and Error Handling">
            </asp:Label>
            
            <br /> <br />
            
            <asp:DropDownList ID="ddlquotes" runat="server" AutoPostBack="True"  onselectedindexchanged="ddlquotes_SelectedIndexChanged">
            </asp:DropDownList>
            
            <br /> <br />
            
            <asp:Label ID="lblquotes" runat="server">
            </asp:Label>
            
            <br /> <br />
            
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="mylink.htm">Link to:</asp:HyperLink>
         </div>
</asp:Content>
