using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TCL.Startup))]
namespace TCL
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
