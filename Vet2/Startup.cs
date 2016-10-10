using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Vet2.Startup))]
namespace Vet2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
