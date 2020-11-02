using System;
using System.Web.UI;

namespace WebForms_sample2.Controls
{
    public partial class Validators : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                lblmsg.Text = "Thank You";
            }
            else
            {
                lblmsg.Text = "Fill up all the fields";
            }
        }
    }
}