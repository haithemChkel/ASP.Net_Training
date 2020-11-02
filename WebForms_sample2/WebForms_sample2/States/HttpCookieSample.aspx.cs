using System;
using System.Web;

namespace WebForms_sample2.States
{
    public partial class HttpCookieSample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {           
            //--------------- Fetching Cookie -------------------------//  
            var co_val = Request.Cookies["student"].Value;
            Label1.Text = co_val;
        }

        protected void btnstr_Click(object sender, EventArgs e)
        {
            //-------------- Creating Cookie --------------------------//  
            // Creating HttpCookie instance by specifying name "student"  
            HttpCookie cokie = new HttpCookie("student");
            // Assigning value to the created cookie  
            cokie.Value = txtstr.Text;
            // Adding Cookie to the response instance  
            Response.Cookies.Add(cokie);
            Label1.Text = txtstr.Text;
        }
    }
}