<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Inputs.aspx.cs" Inherits="WebForms_sample2.Controls.Inputs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="form-horizontal" style="padding-top: 10px;">
        <div class="form-group">
            <asp:Label ID="Label9" runat="server" Text="Literal" CssClass="col-sm-2 control-label" Font-Bold="True" ForeColor="#FF3300"></asp:Label>
            <asp:Literal ID="Literal1" runat="server" Text="Literal Test"></asp:Literal>
        </div>
        <div class="form-group">
            <asp:Label ID="Label1" runat="server" Text="TextBox" CssClass="col-sm-2 control-label" Font-Bold="True" ForeColor="#FF3300"></asp:Label>
            <asp:TextBox ID="FirstName_tb" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Label ID="Label2" runat="server" Text="Calendar" CssClass="col-sm-2 control-label" Font-Bold="True" ForeColor="#FF3300"></asp:Label>
            <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
        </div>
        <div class="form-group">
            <asp:Label ID="Label3" runat="server" Text="CheckBox" CssClass="col-sm-2 control-label" Font-Bold="True" ForeColor="#FF3300"></asp:Label>
            <asp:CheckBox ID="CheckBox1" runat="server" />
        </div>
        <div class="form-group">
            <asp:Label ID="Label4" runat="server" Text="CheckBoxList" CssClass="col-sm-2 control-label" Font-Bold="True" ForeColor="#FF3300"></asp:Label>
            <asp:CheckBoxList ID="CheckBoxList1" runat="server">
                <asp:ListItem>FR</asp:ListItem>
                <asp:ListItem>CA</asp:ListItem>
                <asp:ListItem>US</asp:ListItem>
            </asp:CheckBoxList>
        </div>
        <div class="form-group">
            <asp:Label ID="Label5" runat="server" Text="DropDownList" CssClass="col-sm-2 control-label" Font-Bold="True" ForeColor="#FF3300"></asp:Label>
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem>US</asp:ListItem>
                <asp:ListItem>FR</asp:ListItem>
                <asp:ListItem>CA</asp:ListItem>
            </asp:DropDownList>
        </div>
        <div class="form-group">
            <asp:Label ID="Label6" runat="server" Text="FileUpload" CssClass="col-sm-2 control-label" Font-Bold="True" ForeColor="#FF3300"></asp:Label>
            <asp:FileUpload ID="FileUpload1" runat="server" />
        </div>
        <div class="form-group">
            <asp:Label ID="Label7" runat="server" Text="RadioButton" CssClass="col-sm-2 control-label" Font-Bold="True" ForeColor="#FF3300"></asp:Label>
            <asp:RadioButton ID="RadioButton1" runat="server" />
        </div>
        <div class="form-group">
            <asp:Label ID="Label8" runat="server" Text="RadioButtonList" CssClass="col-sm-2 control-label" Font-Bold="True" ForeColor="#FF3300"></asp:Label>
            <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                <asp:ListItem>YES</asp:ListItem>
                <asp:ListItem>NO</asp:ListItem>
            </asp:RadioButtonList>
            <input type="text" id="testtext" size="40" runat="server">
        </div>
    </div>
</asp:Content>
