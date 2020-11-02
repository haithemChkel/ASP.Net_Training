using System;

namespace WebForms_sample2.Controls
{
    public partial class Ajax : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.User_messsage.Text = string.Empty;
        }

        protected void Save_btn_Click(object sender, EventArgs e)
        {
            this.User_messsage.Text = $"Welcome {this.FirstName_tb.Text} :)";
        }
    }
}