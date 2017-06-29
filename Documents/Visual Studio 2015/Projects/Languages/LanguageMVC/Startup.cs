using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LanguageMVC.Startup))]
namespace LanguageMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
