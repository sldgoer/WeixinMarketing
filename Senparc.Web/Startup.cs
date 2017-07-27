using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Senparc.Web.Startup))]
namespace Senparc.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
