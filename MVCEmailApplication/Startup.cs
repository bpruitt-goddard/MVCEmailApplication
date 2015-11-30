using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCEmailApplication.Startup))]
namespace MVCEmailApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
