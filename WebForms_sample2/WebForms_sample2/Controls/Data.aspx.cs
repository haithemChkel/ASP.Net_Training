using System;
using WebForms_sample2.ManageUsers;

namespace WebForms_sample2.Controls
{
    public partial class Grids : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.GridView1.DataSource = AppUsers.AllUsers;
            this.GridView1.DataBind();
            this.DataList1.DataSource = AppUsers.AllUsers;
            this.DataList1.DataBind();
        }        
    }
}