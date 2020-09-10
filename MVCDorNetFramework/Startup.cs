using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCDorNetFramework.Startup))]
namespace MVCDorNetFramework
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
