using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCApp_0608.Startup))]
namespace MVCApp_0608
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
