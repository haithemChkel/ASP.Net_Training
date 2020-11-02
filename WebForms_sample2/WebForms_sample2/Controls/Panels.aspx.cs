using System;

namespace WebForms_sample2.Controls
{
    public partial class Panels : System.Web.UI.Page
    {

        protected string[] arrPlanets = new[] { "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Saturn", "Uranus", "Neptune" };


        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void imgMapSolarSystem_Click(object sender, System.Web.UI.WebControls.ImageMapEventArgs e)
        {
            switch (e.PostBackValue)
            {
                case "Sun":
                    {
                        // when user clicks on the Sun area
                        lbDirection.Text = "The Sun is the star at the centre of the Solar System.";
                        break;
                    }

                case "Mercury":
                    {
                        lbDirection.Text = "Mercury is the innermost and smallest planet in the Solar System.";
                        break;
                    }

                case "Venus":
                    {
                        lbDirection.Text = "Venus is the second-closest planet to the Sun.";
                        break;
                    }

                case "Earth":
                    {
                        lbDirection.Text = "Earth is the third planet from the Sun. It is also referred to as the World and the Blue Planet.";
                        break;
                    }

                case "Mars":
                    {
                        lbDirection.Text = "Mars is the fourth planet from the Sun in the Solar System.";
                        break;
                    }

                case "Jupiter":
                    {
                        lbDirection.Text = "Jupiter is the fifth planet from the Sun and the largest planet within the Solar System.";
                        break;
                    }

                case "Saturn":
                    {
                        lbDirection.Text = "Saturn is the sixth planet from the Sun and the second largest planet in the Solar System, after Jupiter.";
                        break;
                    }

                case "Uranus":
                    {
                        lbDirection.Text = "Uranus is the seventh planet from the Sun, and the third-largest and fourth most massive planet in the Solar System.";
                        break;
                    }

                case "Neptune":
                    {
                        lbDirection.Text = "Neptune is the eighth planet from the Sun in our Solar System.";
                        break;
                    }

                default:
                    {
                        break;
                    }
            }
        }


        protected void MultiView1_ActiveViewChanged(object sender, EventArgs e)
        {
            
        }
    }
}