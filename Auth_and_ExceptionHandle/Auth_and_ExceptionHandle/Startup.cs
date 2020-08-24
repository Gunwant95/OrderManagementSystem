using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Auth_and_ExceptionHandle.Startup))]
namespace Auth_and_ExceptionHandle
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
