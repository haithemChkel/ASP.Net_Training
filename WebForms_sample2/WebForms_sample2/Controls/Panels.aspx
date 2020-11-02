<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Panels.aspx.cs" Inherits="WebForms_sample2.Controls.Panels" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="form-horizontal" style="padding-top: 10px;">
        <asp:Panel ID="Panel1" runat="server" CssClass="form-group" BorderStyle="Dotted">
            <asp:Label ID="Label9" runat="server" Text="Image" CssClass="col-sm-2 control-label" Font-Bold="True" ForeColor="#FF3300"></asp:Label>
            <asp:Image ID="Image1" runat="server" ImageUrl="https://payyourintern.com/wp-content/uploads/2020/08/Google.png" />
        </asp:Panel>
        <asp:Panel class="form-horizontal" Style="padding-top: 10px;" runat="server" BorderStyle="Dotted">
            <asp:Label ID="Label1" runat="server" Text="ImageMap" CssClass="col-sm-2 control-label" Font-Bold="True" ForeColor="#FF3300"></asp:Label>
            <div>
                <p>Please select the planet from the image to navigate the iframe</p>

                <asp:ImageMap ID="imgMapSolarSystem" runat="server" ImageUrl="~/solarsystem.jpg" HotSpotMode="PostBack" OnClick="imgMapSolarSystem_Click">

                    <asp:RectangleHotSpot PostBackValue="Sun"
                        AlternateText="Sun"
                        Top="0" Left="0" Right="110" Bottom="258"
                        HotSpotMode="PostBack" />

                    <asp:CircleHotSpot PostBackValue="Mercury"
                        AlternateText="Mercury"
                        X="189" Y="172" Radius="3"
                        HotSpotMode="PostBack" />

                    <asp:CircleHotSpot PostBackValue="Venus"
                        AlternateText="Venus"
                        X="227" Y="172" Radius="10"
                        HotSpotMode="PostBack" />

                    <asp:CircleHotSpot PostBackValue="Earth"
                        AlternateText="Earth"
                        X="277" Y="172" Radius="10"
                        HotSpotMode="PostBack" />

                    <asp:CircleHotSpot PostBackValue="Mars"
                        AlternateText="Mars"
                        X="324" Y="172" Radius="8"
                        HotSpotMode="PostBack" />

                    <asp:CircleHotSpot PostBackValue="Jupiter"
                        AlternateText="Jupiter"
                        X="410" Y="172" Radius="55"
                        HotSpotMode="PostBack" />

                    <asp:PolygonHotSpot PostBackValue="Saturn"
                        AlternateText="Saturn"
                        Coordinates="492,235,471,228,522,179,540,133,581,126,593,134,657,110,660,126,615,167,608,203,563,219,542,214"
                        HotSpotMode="PostBack" />

                    <asp:CircleHotSpot PostBackValue="Uranus"
                        AlternateText="Uranus"
                        X="667" Y="172" Radius="21"
                        HotSpotMode="PostBack" />

                    <asp:CircleHotSpot PostBackValue="Neptune"
                        AlternateText="Neptune"
                        X="736" Y="172" Radius="18"
                        HotSpotMode="PostBack" />

                </asp:ImageMap>
                <p>
                    <asp:Label ID="lbDirection" runat="server"></asp:Label>
                </p>

            </div>
        </asp:Panel>
        <asp:Panel ID="Panel2" runat="server" CssClass="form-group" BorderStyle="Dotted" Style="padding-top: 10px;">
            <asp:Label ID="Label2" runat="server" Text="MultiView" CssClass="col-sm-2 control-label" Font-Bold="True" ForeColor="#FF3300"></asp:Label>
            <div>
                <h2>MultiView and View Controls</h2>


                <hr />

                <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="2">
                    <asp:View ID="View1" runat="server">
                        <h3>This is view 1</h3>
                        <br />
                        <asp:Button CommandName="NextView" ID="btnnext1" runat="server" Text="Go To Next" />
                        <asp:Button CommandArgument="View3" CommandName="SwitchViewByID" ID="btnlast" runat="server" Text="Go To Last" />
                    </asp:View>

                    <asp:View ID="View2" runat="server">
                        <h3>This is view 2</h3>
                        <asp:Button CommandName="NextView" ID="btnnext2" runat="server" Text="Go To Next" />
                        <asp:Button CommandName="PrevView" ID="btnprevious2" runat="server" Text="Go To Previous View" />
                    </asp:View>

                    <asp:View ID="View3" runat="server">
                        <h3>This is view 3</h3>
                        <br />
                        <asp:Calendar ID="Calender1" runat="server"></asp:Calendar>
                        <br />
                        <asp:Button CommandArgument="0" CommandName="SwitchViewByIndex" ID="btnfirst" runat="server" Text="Go To Next" />
                        <asp:Button CommandName="PrevView" ID="btnprevious" runat="server" Text="Go To Previous View" />
                    </asp:View>

                </asp:MultiView>
            </div>
        </asp:Panel>
        <asp:Panel ID="Panel3" runat="server" CssClass="form-group" BorderStyle="Dotted" Style="padding-top: 10px;">
            <asp:Label ID="Label3" runat="server" Text="WizardStep" CssClass="col-sm-2 control-label" Font-Bold="True" ForeColor="#FF3300"></asp:Label>
            <div>
                <asp:Wizard ID="Wizard1" runat="server">
                    <WizardSteps>
                        <asp:WizardStep ID="WizardStep1" runat="server" Title="Step 1">
                            <h3>This is Step 1</h3>
                        </asp:WizardStep>
                        <asp:WizardStep ID="WizardStep2" runat="server" Title="Step 2">
                            <h3>This is Step 2</h3>
                            <br />
                            <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
                            <br />
                        </asp:WizardStep>
                    </WizardSteps>
                </asp:Wizard>
            </div>
        </asp:Panel>
        <asp:Panel ID="Panel4" runat="server" CssClass="form-group" BorderStyle="Dotted" Style="padding-top: 10px;">
            <asp:Label ID="Label4" runat="server" Text="AdRotator" CssClass="col-sm-2 control-label" Font-Bold="True" ForeColor="#FF3300"></asp:Label>
            <div>
                <asp:AdRotator ID="AdRotator1" runat="server" AdvertisementFile="~/Controls/ads.xml" />
            </div>
        </asp:Panel>
    </div>
</asp:Content>
