using System;
using System.Web.UI;

namespace WebForms_sample2
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.Cache["UserNAme"] = "HELLO"; 
        }
    }
}