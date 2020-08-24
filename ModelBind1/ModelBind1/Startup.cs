using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ModelBind1.Startup))]
namespace ModelBind1
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
