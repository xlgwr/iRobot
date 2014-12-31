using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApp.SPA.Startup))]
namespace WebApp.SPA
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
