using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Languages.Startup))]
namespace Languages
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
