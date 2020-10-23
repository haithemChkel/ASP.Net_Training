using System;

namespace WebForms_sample1.User
{
    public partial class UsersList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UsersGridView.DataSource = AppUsers.AllUsers;
            UsersGridView.DataBind();
        }
    }
}