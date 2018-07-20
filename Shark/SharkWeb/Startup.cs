using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SharkWeb.Startup))]
namespace SharkWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
