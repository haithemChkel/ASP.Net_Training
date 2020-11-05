using System;
using System.Data;
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

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected_lbl.Text = GridView1.SelectedRow.Cells[1].Text;
        }
    }
}