using System;

namespace WebForms_sample2.States
{
    public partial class ViewState : System.Web.UI.Page
    {
        public int counter
        {
            get
            {
                if (ViewState["pcounter"] != null)
                {
                    return ((int)ViewState["pcounter"]);
                }
                else
                {
                    return 0;
                }
            }

            set
            {
                ViewState["pcounter"] = value;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            counter++;
            lblCounter.Text = counter.ToString();
        }

        protected void btnIncrement_Click(object sender, EventArgs e)
        {
        }
    }
}