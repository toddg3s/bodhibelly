using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(bodhibelly2.Startup))]
namespace bodhibelly2
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
