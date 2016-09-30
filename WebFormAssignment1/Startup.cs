using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebFormAssignment1.Startup))]
namespace WebFormAssignment1
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
