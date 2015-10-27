using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mvcid.Startup))]
namespace Mvcid
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
