using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Sifact.Startup))]
namespace Sifact
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
