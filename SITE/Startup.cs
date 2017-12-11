using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SITE.Startup))]
namespace SITE
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
