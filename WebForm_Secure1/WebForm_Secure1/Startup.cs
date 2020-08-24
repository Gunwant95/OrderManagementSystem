using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebForm_Secure1.Startup))]
namespace WebForm_Secure1
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
