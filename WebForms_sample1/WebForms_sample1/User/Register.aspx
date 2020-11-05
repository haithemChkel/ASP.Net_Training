<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="WebForms_sample1.User.Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="form-horizontal" style="padding-top: 10px;">
        <div class="form-group">
            <asp:Label ID="Label1" runat="server" Text="First Name" CssClass="col-sm-2 control-label"></asp:Label>
            <asp:TextBox ID="FirstName_tb" runat="server" CssClass="form-control" BackColor="#FF6699"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Label ID="Label2" runat="server" Text="Last Name" CssClass="col-sm-2 control-label"></asp:Label>
            <asp:TextBox ID="LastName_tb" runat="server" CssClass="form-control" BorderColor="#3366FF" BorderStyle="Dotted" BorderWidth="5px" OnTextChanged="LastName_tb_TextChanged"></asp:TextBox>
            <input id="Text1" type="text" runat="server" />
        </div>
        <div class="form-group">
            <asp:Label ID="Label3" runat="server" Text="Gender" CssClass="col-sm-2 control-label"></asp:Label>
            <asp:RadioButtonList ID="Gender_RadioButtonList" runat="server">
                <asp:ListItem Value="1">Male</asp:ListItem>
                <asp:ListItem Value="2">Female</asp:ListItem>
            </asp:RadioButtonList>
        </div>
        <div class="form-group">
            <div class="col-sm-offset-2 col-sm-10">
                <asp:Button ID="Save_btn" runat="server" Text="Save" CssClass="btn btn-default" OnClick="Save_btn_Click" />
            </div>
            <asp:Label ID="ispostback_lbl" runat="server" Text="Label"></asp:Label>
        </div>
    </div>
</asp:Content>
