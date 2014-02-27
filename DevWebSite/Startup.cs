using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DevWebSite.Startup))]
namespace DevWebSite
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
