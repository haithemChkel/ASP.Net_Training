using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using RentACar.Dto;
using RentACar.Infra.DI;
using RentACar.Models;
using RentACar.Services.Interfaces;
using System;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RentACar
{
    public partial class _Default : Page
    {
        private IUserService _userService;
        private IBaseService<Roles, int> _rolesService;
        public _Default(IUserService userService, IBaseService<Roles, int> rolesService)
        {
            _userService = userService;
            _rolesService = rolesService;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                // Create a new table.
                DataTable usersTable = new DataTable("GvUsers");
                // Create the columns.
                usersTable.Columns.Add("Id", typeof(string));
                usersTable.Columns.Add("Email", typeof(string));
                usersTable.Columns.Add("UserName", typeof(string));

                var users = _userService.GetAll();
                foreach (var user in users)
                {
                    DataRow tableRow = usersTable.NewRow();
                    tableRow["Id"] = user.Id;
                    tableRow["Email"] = user.Email;
                    tableRow["UserName"] = user.UserName;
                    usersTable.Rows.Add(tableRow);
                }
                //Persist the table in the Session object.
                Session["GvUsers"] = usersTable;

                //Bind data to the GridView control.
                BindData();

            }


        }

        protected void GvUsers_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GvUsers.PageIndex = e.NewPageIndex;
            //Bind data to the GridView control.
            BindData();
        }

        protected void GvUsers_RowEditing(object sender, GridViewEditEventArgs e)
        {
            //Set the edit index.
            GvUsers.EditIndex = e.NewEditIndex;
            //Bind data to the GridView control.
            BindData();
        }

        protected void GvUsers_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            //Reset the edit index.
            GvUsers.EditIndex = -1;
            //Bind data to the GridView control.
            BindData();
        }

        protected void GvUsers_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            //Retrieve the table from the session object.
            DataTable dt = (DataTable)Session["GvUsers"];

            //Update the values.
            GridViewRow row = GvUsers.Rows[e.RowIndex];
            var user = new User();
            dt.Rows[row.DataItemIndex]["Id"] = ((TextBox)(row.Cells[1].Controls[0])).Text;
            user.Id = ((TextBox)(row.Cells[1].Controls[0])).Text;
            dt.Rows[row.DataItemIndex]["Email"] = ((TextBox)(row.Cells[2].Controls[0])).Text;
            user.Email = ((TextBox)(row.Cells[2].Controls[0])).Text;
            dt.Rows[row.DataItemIndex]["UserName"] = ((TextBox)(row.Cells[3].Controls[0])).Text;
            user.UserName = ((TextBox)(row.Cells[3].Controls[0])).Text;

            if (string.IsNullOrEmpty(user.Id))
            {
                var manager = Context.GetOwinContext().GetUserManager<ApplicationUserManager>();
                var applicationUser = new ApplicationUser() { UserName = user.Email, Email = user.Email };
                IdentityResult result = manager.Create(applicationUser, "DFfff_x56565_y");
                if (result.Succeeded)
                {
                    dt.Rows[row.DataItemIndex]["Id"] = applicationUser.Id;
                }
            }
            else
            {
                _userService.Update(user.Id, user);
            }
            //Reset the edit index.
            GvUsers.EditIndex = -1;

            //Bind data to the GridView control.
            BindData();
        }

        private void BindData()
        {
            GvUsers.DataSource = Session["GvUsers"];
            GvUsers.DataBind();
        }

        protected void Btn_AddNewUser_Click(object sender, EventArgs e)
        {
            //Retrieve the table from the session object.
            DataTable dt = (DataTable)Session["GvUsers"];
            var newRow = dt.NewRow();
            dt.Rows.Add(newRow);
            GvUsers.DataSource = dt;
            GvUsers.EditIndex = dt.Rows.IndexOf(newRow);
            GvUsers.DataBind();
        }

        protected void GvUsers_RowCreated(object sender, GridViewRowEventArgs e)
        {
            var row = e.Row;

            if (row.Cells.Count > 2 && row.Cells[1].Controls.Count > 0)
            {
                var textBox = ((TextBox)(row.Cells?[1]?.Controls?[0]));
                var id = textBox.Text;
                if (string.IsNullOrEmpty(id))
                {
                    textBox.Enabled = false;
                }
            }
        }
    }
}