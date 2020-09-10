using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebFormAppWithAuth.Startup))]
namespace WebFormAppWithAuth
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
