using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RazorDemo_PartialView.Startup))]
namespace RazorDemo_PartialView
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
