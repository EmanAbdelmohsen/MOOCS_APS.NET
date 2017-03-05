using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MOOCS.Startup))]
namespace MOOCS
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
