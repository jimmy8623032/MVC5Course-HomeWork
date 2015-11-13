using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Week1.Startup))]
namespace Week1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
