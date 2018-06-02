using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SharkSite.Startup))]
namespace SharkSite
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
