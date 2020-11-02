<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Buttons.aspx.cs" Inherits="WebForms_sample2.Controls.Buttons" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="form-horizontal" style="padding-top: 10px;">
        <div class="form-group">
            <asp:Label ID="Label9" runat="server" Text="Button" CssClass="col-sm-2 control-label" Font-Bold="True" ForeColor="#FF3300"></asp:Label>
            <asp:Button ID="Button1" runat="server" Text="Button" />
        </div>
        <div class="form-group">
            <asp:Label ID="Label1" runat="server" Text="ImageButton" CssClass="col-sm-2 control-label" Font-Bold="True" ForeColor="#FF3300"></asp:Label>
            <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="https://payyourintern.com/wp-content/uploads/2020/08/Google.png" />
        </div>
        <div class="form-group">
            <asp:Label ID="Label2" runat="server" Text="LinkButton" CssClass="col-sm-2 control-label" Font-Bold="True" ForeColor="#FF3300"></asp:Label>
            <asp:LinkButton ID="LinkButton1" runat="server" Text="GO to" PostBackUrl="https://payyourintern.com/wp-content/uploads/2020/08/Google.png"></asp:LinkButton>
        </div>
    </div>
</asp:Content>
