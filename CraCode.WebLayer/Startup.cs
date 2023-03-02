using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CraCode.WebLayer.Startup))]
namespace CraCode.WebLayer
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
