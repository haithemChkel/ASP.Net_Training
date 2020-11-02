using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForms_sample2.States
{
    public partial class CookieCollectionSample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Setting expiring date and time of the cookies  
            //Request.Cookies["computer"].Expires = DateTime.Now.AddDays(1);
            FetchingCookies(Request.Cookies);
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Label2.Text = "";
            // --------------- Adding Coockies ---------------------//  
            if (apple.Checked)
                Response.Cookies["computer"]["apple"] = "apple";
            if (dell.Checked)
                Response.Cookies["computer"]["dell"] = "dell";
            if (lenevo.Checked)
                Response.Cookies["computer"]["lenevo"] = "lenevo";
            if (acer.Checked)
                Response.Cookies["computer"]["acer"] = "acer";
            if (sony.Checked)
                Response.Cookies["computer"]["sony"] = "sony";
            if (wipro.Checked)
                Response.Cookies["computer"]["wipro"] = "wipro";
            // --------------- Fetching Cookies -----------------------//  
            FetchingCookies(Response.Cookies);
            Response.Cookies["computer"].Expires = DateTime.Now.AddDays(1);
        }

        private void FetchingCookies(HttpCookieCollection cookies)
        {
            if (cookies["computer"].Values.ToString() != null)
            {
                if (cookies["computer"]["apple"] != null)
                    Label2.Text += cookies["computer"]["apple"] + " ";
                if (cookies["computer"]["dell"] != null)
                    Label2.Text += cookies["computer"]["dell"] + " ";
                if (cookies["computer"]["lenevo"] != null)
                    Label2.Text += cookies["computer"]["lenevo"] + " ";
                if (cookies["computer"]["acer"] != null)
                    Label2.Text += cookies["computer"]["acer"] + " ";
                if (cookies["computer"]["sony"] != null)
                    Label2.Text += cookies["computer"]["sony"] + " ";
                if (cookies["computer"]["wipro"] != null)
                    Label2.Text += cookies["computer"]["wipro"] + " ";
            }
            else Label2.Text = "Please select your choice";
        }
    }
}