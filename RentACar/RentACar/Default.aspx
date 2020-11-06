<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="RentACar._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <div class="row">
        <asp:Button ID="Btn_AddNewUser" runat="server" Text="Add New User" OnClick="Btn_AddNewUser_Click" />
    </div>
    <div class="row">

        <asp:GridView ID="GvUsers" runat="server"
            AutoGenerateEditButton="True"
            AllowPaging="true"
            OnRowEditing="GvUsers_RowEditing"
            OnRowCancelingEdit="GvUsers_RowCancelingEdit"
            OnRowUpdating="GvUsers_RowUpdating"
            OnPageIndexChanging="GvUsers_PageIndexChanging" OnRowCreated="GvUsers_RowCreated">
        </asp:GridView>
    </div>
    <div class="row">
    </div>
</asp:Content>
