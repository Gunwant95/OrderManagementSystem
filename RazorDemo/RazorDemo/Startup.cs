using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RazorDemo.Startup))]
namespace RazorDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
