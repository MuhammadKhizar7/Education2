using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Education2.Startup))]
namespace Education2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
