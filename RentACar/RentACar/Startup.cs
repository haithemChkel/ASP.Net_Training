using Microsoft.Owin;
using Owin;
using RentACar.Infra.DI;

[assembly: OwinStartupAttribute(typeof(RentACar.Startup))]
namespace RentACar
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
            Registration.Register("DefaultConnection");
        }
    }
}
