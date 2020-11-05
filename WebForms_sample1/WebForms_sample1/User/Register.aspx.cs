using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForms_sample1.User
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.ispostback_lbl.Text = IsPostBack ? "EST UN POSTBACK" : "EST GET QUERY";
        }

        protected void Save_btn_Click(object sender, EventArgs e)
        {
            var user = new User();
            user.LastName = LastName_tb.Text;
            user.FirstName = FirstName_tb.Text;
            user.Gender = string.IsNullOrEmpty(Gender_RadioButtonList.SelectedValue) ? null : (Genders?)int.Parse(Gender_RadioButtonList.SelectedValue);
            AppUsers.AllUsers.Add(user);
            //Response.Redirect("UsersList.aspx", false);
        }

        protected void LastName_tb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}