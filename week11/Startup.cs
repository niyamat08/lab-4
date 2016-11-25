using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(week11.Startup))]
namespace week11
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
