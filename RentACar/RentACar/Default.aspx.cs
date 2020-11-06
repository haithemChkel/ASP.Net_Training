using RentACar.Dto;
using RentACar.Infra.DI;
using RentACar.Services.Interfaces;
using System;
using System.Web.UI;

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

            IBaseService<Roles, int> rolesService = Injector.Inject<IBaseService<Roles, int>>();
            if(rolesService != null)
            {
                var roles = rolesService.GetAll();
                GvRoles.DataSource = roles;
                this.GvRoles.DataBind();
            }       

        }
    }
}