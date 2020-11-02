using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebForms_Authentication.Startup))]
namespace WebForms_Authentication
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
