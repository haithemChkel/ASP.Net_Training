<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DownloadFile.aspx.cs" Inherits="WebForms_sample2.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <br />  

    <br />  

    <br />  

    <p>  
        Click the button to download a file</p>  
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Download" />  
    <br />  
    <br />  
    <asp:Label ID="Label1" runat="server"></asp:Label>  
</asp:Content>
