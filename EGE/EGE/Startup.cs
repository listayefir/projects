using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EGE.Startup))]
namespace EGE
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
