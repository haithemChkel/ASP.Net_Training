using RentACar.Dto;
using RentACar.Infra.DI;
using RentACar.Models;
using RentACar.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RentACar
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var userService = Injector.Inject<IUserService>();
            if(userService != null)
            {
                var users = userService.GetAll();
                this.gvUsers.DataSource = users;
                this.gvUsers.DataBind();
            }

            IBusinessService<Roles, int> rolesService = Injector.Inject<IBusinessService<Roles, int>>();
            if(rolesService != null)
            {
                var roles = rolesService.GetAll();
                GvRoles.DataSource = roles;
                this.GvRoles.DataBind();
            }       

        }
    }
}