using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FaniloSimpleInjector.Startup))]
namespace FaniloSimpleInjector
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
