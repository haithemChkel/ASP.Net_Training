using System;
using System.Collections.Generic;
using WebForms_sample2.ManageUsers;

namespace WebForms_sample2.Xml
{
    public partial class Xml : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                this.TextBox1.Text = AppUsers.AllUsers.Serialize<Users>();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var list = XmlSerializerExt.DeserializeToObject<Users>(TextBox1.Text);
            this.GridView1.DataSource = list;
            this.GridView1.DataBind();
        }
    }
}