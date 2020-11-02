using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForms_sample2.Linq
{
    public partial class SimpleQuery : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Books> books = Books.GetBooks();
            var booktitles = from b in books select b.Title;
            // or
            var booktitlesLamdha = books.Select(x => x.Title);             

            IEnumerable<Salesdetails> sales = Salesdetails.Getsalesdetails();

            var booktitlesWithJoin = from b in books
                             join s in sales on b.ID equals s.ID
                             let totalprofit = (b.Price * s.sales) // The let clause allows defining a variable and assigning it a value calculated from the data values.
                             select new { Name = b.Title, Pages = s.pages, TotalSale = totalprofit };

            foreach (var title in booktitlesWithJoin)
                lblbooks.Text += String.Format("{0} <br />", title);
        }
    }
}