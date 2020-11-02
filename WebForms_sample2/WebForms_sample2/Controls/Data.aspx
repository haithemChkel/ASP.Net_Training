<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Data.aspx.cs" Inherits="WebForms_sample2.Controls.Grids" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="form-horizontal" style="padding-top: 10px;">
        <asp:Panel ID="Panel1" runat="server" CssClass="form-group" BorderStyle="Dotted">
            <asp:Label ID="Label9" runat="server" Text="GridView" CssClass="col-sm-2 control-label" Font-Bold="True" ForeColor="#FF3300"></asp:Label>
            <asp:GridView ID="GridView1" runat="server" CssClass="table"></asp:GridView>
        </asp:Panel>
    </div>
    <div class="form-horizontal" style="padding-top: 10px;">
        <asp:Panel ID="Panel2" runat="server" CssClass="form-group" BorderStyle="Dotted">
            <asp:Label ID="Label1" runat="server" Text="DataList" CssClass="col-sm-2 control-label" Font-Bold="True" ForeColor="#FF3300"></asp:Label>
            <asp:DataList ID="DataList1" runat="server" RepeatColumns="3"
                CellSpacing="10" RepeatLayout="Table">
                <ItemTemplate>
                    <table class="table table-bordered">
                        <tr class="info">
                            <th colspan="2">
                                <%# Eval("LastName") %></b>
                            </th>
                        </tr>
                        <tr>
                            <td>First Name:  
                            </td>
                            <td colspan="2">
                                <%# Eval("FirstName") %>
                            </td>
                        </tr>
                        <tr>
                            <td>Gender:  
                            </td>
                            <td>
                                <%# Eval("Gender")%>  
                            </td>
                        </tr>
                    </table>
                </ItemTemplate>
            </asp:DataList>
        </asp:Panel>
    </div>
    <div class="form-horizontal" style="padding-top: 10px;">
        <asp:Panel ID="Panel3" runat="server" CssClass="form-group" BorderStyle="Dotted">
            <asp:Label ID="Label2" runat="server" Text="DataList" CssClass="col-sm-2 control-label" Font-Bold="True" ForeColor="#FF3300"></asp:Label>
            <asp:GridView ID="GridView2" runat="server" DataSourceID="SqlDataSource1" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="ArtistId" HeaderText="ArtistId" SortExpression="ArtistId"></asp:BoundField>
                    <asp:BoundField DataField="ArtistName" HeaderText="ArtistName" SortExpression="ArtistName"></asp:BoundField>
                    <asp:BoundField DataField="ActiveFrom" HeaderText="ActiveFrom" SortExpression="ActiveFrom"></asp:BoundField>
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource runat="server" ID="SqlDataSource1" ConnectionString='<%$ ConnectionStrings:MusicConnectionString %>' SelectCommand="SELECT [ArtistId], [ArtistName], [ActiveFrom] FROM [Artists]"></asp:SqlDataSource>
        </asp:Panel>
    </div>
</asp:Content>
