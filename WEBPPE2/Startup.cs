using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WEBPPE2.Startup))]
namespace WEBPPE2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
