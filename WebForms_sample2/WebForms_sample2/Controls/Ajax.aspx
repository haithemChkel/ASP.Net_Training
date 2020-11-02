<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Ajax.aspx.cs" Inherits="WebForms_sample2.Controls.Ajax" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:Panel class="form-horizontal" Style="padding-top: 10px;" runat="server">
                <div class="form-group">
                    <asp:Label ID="Label1" runat="server" Text="First Name" CssClass="col-sm-2 control-label"></asp:Label>
                    <asp:TextBox ID="FirstName_tb" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:Label ID="Label2" runat="server" Text="Last Name" CssClass="col-sm-2 control-label"></asp:Label>
                    <asp:TextBox ID="LastName_tb" runat="server" CssClass="form-control"></asp:TextBox>
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
                </div>
            </asp:Panel>
            <asp:Label ID="User_messsage" runat="server" Text="Label"></asp:Label>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
