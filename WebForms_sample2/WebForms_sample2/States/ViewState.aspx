<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ViewState.aspx.cs" Inherits="WebForms_sample2.States.ViewState" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <h3>View State demo</h3>

        Page Counter:
            
            <asp:Label ID="lblCounter" runat="server" />
        <asp:Button ID="btnIncrement" runat="server" Text="Add Count" OnClick="btnIncrement_Click" />
    </div>
</asp:Content>
