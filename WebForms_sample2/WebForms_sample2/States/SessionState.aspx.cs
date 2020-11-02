using System;

namespace WebForms_sample2.States
{
    public partial class SessionState : System.Web.UI.Page
    {
        String mystr;

        protected void Page_Load(object sender, EventArgs e)
        {
            this.lblSession_ID.Text = this.Session.SessionID;
            this.lblshstr.Text = this.mystr;
            this.lblsession.Text = (String)this.Session["str"];
        }

        protected void btnstr_Click(object sender, EventArgs e)
        {
            this.mystr = this.txtstr.Text;
            this.Session["str"] = this.txtstr.Text;
            this.lblshstr.Text = this.mystr;
            this.lblsession.Text = (String)this.Session["str"];
        }
    }
}