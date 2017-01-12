using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BWGDroidSite.Startup))]
namespace BWGDroidSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
