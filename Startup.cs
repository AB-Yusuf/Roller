using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Roller.Startup))]
namespace Roller
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
