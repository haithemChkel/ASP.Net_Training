<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SessionState.aspx.cs" Inherits="WebForms_sample2.States.SessionState" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        &nbsp; &nbsp; &nbsp;
            
            <table style="width: 568px; height: 103px">

                <tr>
                    <td style="width: 209px">
                        <asp:Label ID="lblstr" runat="server" Text="Enter a String" Style="width: 94px">
                        </asp:Label>
                    </td>

                    <td style="width: 317px">
                        <asp:TextBox ID="txtstr" runat="server" Style="width: 227px">
                        </asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td style="width: 209px"></td>
                    <td style="width: 317px"></td>
                </tr>

                <tr>
                    <td style="width: 209px">
                        <asp:Button ID="btnnrm" runat="server"
                            Text="No action button" Style="width: 128px" />
                    </td>

                    <td style="width: 317px">
                        <asp:Button ID="btnstr" runat="server"
                            OnClick="btnstr_Click" Text="Submit the String" />
                    </td>
                </tr>

                <tr>
                    <td style="width: 209px"></td>

                    <td style="width: 317px"></td>
                </tr>
                <tr>
                    <td style="width: 209px">
                        <asp:Label ID="Label3" runat="server">
                            Session ID:
                        </asp:Label>
                        <asp:Label ID="lblSession_ID" runat="server">
                        </asp:Label>
                    </td>

                    <td style="width: 317px"></td>
                </tr>
                <tr>
                    <td style="width: 209px">
                         <asp:Label ID="Label2" runat="server">
                            From Session :
                        </asp:Label>
                        <asp:Label ID="lblsession" runat="server" Style="width: 231px">
                        </asp:Label>
                    </td>

                    <td style="width: 317px"></td>
                </tr>

                <tr>
                    <td style="width: 209px">
                        <asp:Label ID="Label1" runat="server">
                            From Page :
                        </asp:Label>
                        <asp:Label ID="lblshstr" runat="server">
                        </asp:Label>
                    </td>

                    <td style="width: 317px"></td>
                </tr>

            </table>

    </div>
</asp:Content>
