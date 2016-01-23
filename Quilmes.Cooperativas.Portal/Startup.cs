using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Quilmes.Cooperativas.Portal.Startup))]
namespace Quilmes.Cooperativas.Portal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
