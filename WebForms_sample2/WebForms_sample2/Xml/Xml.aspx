<%@ Page Title="" ValidateRequest="false" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Xml.aspx.cs" Inherits="WebForms_sample2.Xml.Xml" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div  class="row">
        <asp:TextBox ID="TextBox1" runat="server" TextMode="MultiLine" CssClass="row"></asp:TextBox>
    </div>
    <div class="row">
        <asp:Button ID="Button1" runat="server" Text="Deserialize To List" OnClick="Button1_Click" />
    </div>
     <div  class="row">
         <asp:GridView ID="GridView1" runat="server" CssClass="table"></asp:GridView>
    </div>
</asp:Content>
