using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(bodhibelly.Startup))]
namespace bodhibelly
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
