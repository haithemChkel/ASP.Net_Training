<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="HttpCookieSample.aspx.cs" Inherits="WebForms_sample2.States.HttpCookieSample" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <div style="width: 209px">
            <asp:Label ID="lblstr" runat="server" Text="Enter a String" Style="width: 94px">
            </asp:Label>
        </div>

        <div style="width: 317px">
            <asp:TextBox ID="txtstr" runat="server" Style="width: 227px">
            </asp:TextBox>
        </div>
        <div style="width: 317px">
            <asp:Button ID="btnstr" runat="server"
                OnClick="btnstr_Click" Text="Submit the String" />
        </div>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </div>
</asp:Content>
