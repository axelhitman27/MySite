using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BetData.Startup))]
namespace BetData
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
