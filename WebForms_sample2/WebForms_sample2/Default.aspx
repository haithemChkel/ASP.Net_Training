<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebForms_sample2._Default" %>
<%@ OutputCache Duration="9999999" VaryByParam="None" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>ASP.NET</h1>
        <p class="lead">ASP.NET is a free web framework for building great Web sites and Web applications using HTML, CSS, and JavaScript.</p>
        <p><a href="http://www.asp.net" class="btn btn-primary btn-lg">Learn more &raquo;</a></p>
    </div>

    <div class="row">
        <table class="table table-bordered table-hover">
            <tbody>
                <tr>
                    <th>Control Name</th>
                    <th>Applicable Events</th>
                    <th>Description</th>
                </tr>
                <tr>
                    <td>Label</td>
                    <td>None</td>
                    <td>It is used to display text on the HTML page.</td>
                </tr>
                <tr>
                    <td>TextBox</td>
                    <td>TextChanged</td>
                    <td>It is used to create a text input in the form.</td>
                </tr>
                <tr>
                    <td>Button</td>
                    <td>Click, Command</td>
                    <td>It is used to create a button. </td>
                </tr>
                <tr>
                    <td>LinkButton</td>
                    <td>Click, Command</td>
                    <td>It is used to create a button that looks similar to the hyperlink.</td>
                </tr>
                <tr>
                    <td>ImageButton</td>
                    <td>Click</td>
                    <td>It is used to create an imagesButton. Here, an image works as a Button.</td>
                </tr>
                <tr>
                    <td>Hyperlink</td>
                    <td>None</td>
                    <td>It is used to create a hyperlink control that responds to a click event.</td>
                </tr>
                <tr>
                    <td>DropDownList</td>
                    <td>SelectedIndexChanged</td>
                    <td>It is used to create a dropdown list control.</td>
                </tr>
                <tr>
                    <td>ListBox</td>
                    <td>SelectedIndexCnhaged</td>
                    <td>It is used to create a ListBox control like the HTML control.</td>
                </tr>
                <tr>
                    <td>DataGrid</td>
                    <td>CancelCommand, EditCommand, DeleteCommand, ItemCommand, SelectedIndexChanged, PageIndexChanged, SortCommand, UpdateCommand, ItemCreated, ItemDataBound</td>
                    <td>It used to create a frid that is used to show data. We can also perform paging, sorting, and formatting very easily with this control.</td>
                </tr>
                <tr>
                    <td>DataList</td>
                    <td>CancelCommand, EditCommand, DeleteCommand, ItemCommand, SelectedIndexChanged, UpdateCommand, ItemCreated, ItemDataBound</td>
                    <td>It is used to create datalist that is non-tabular and used to show data.</td>
                </tr>
                <tr>
                    <td>CheckBox</td>
                    <td>CheckChanged</td>
                    <td>It is used to create checkbox.</td>
                </tr>
                <tr>
                    <td>CheckBoxList</td>
                    <td>SelectedIndexChanged</td>
                    <td>It is used to create a group of check boxes that all work together.</td>
                </tr>
                <tr>
                    <td>RadioButton</td>
                    <td>CheckChanged</td>
                    <td>It is used to create radio button.</td>
                </tr>
                <tr>
                    <td>RadioButtonList</td>
                    <td>SelectedIndexChanged</td>
                    <td>It is used to create a group of radio button controls that all work together.</td>
                </tr>
                <tr>
                    <td>Image</td>
                    <td>None</td>
                    <td>It is used to show image within the page.</td>
                </tr>
                <tr>
                    <td>Panel</td>
                    <td>None</td>
                    <td>It is used to create a panel that works as a container.</td>
                </tr>
                <tr>
                    <td>PlaceHolder</td>
                    <td>None</td>
                    <td>It is used to set placeholder for the control.</td>
                </tr>
                <tr>
                    <td>Calendar</td>
                    <td>SelectionChanged, VisibleMonthChanged, DayRender</td>
                    <td>It is used to create a calendar. We can set the default date, move forward and backward etc.</td>
                </tr>
                <tr>
                    <td>AdRotator</td>
                    <td>AdCreated</td>
                    <td>It allows us to specify a list of ads to display. Each time the user re-displays the page.</td>
                </tr>
                <tr>
                    <td>Table</td>
                    <td>None</td>
                    <td>It is used to create table.</td>
                </tr>
                <tr>
                    <td>XML</td>
                    <td>None</td>
                    <td>It is used to display XML documents within the HTML.</td>
                </tr>
                <tr>
                    <td>Literal</td>
                    <td>None</td>
                    <td>It is like a label in that it displays a literal, but allows us to create new literals at runtime and place them into this control.</td>
                </tr>
            </tbody>
        </table>
    </div>
</asp:Content>
