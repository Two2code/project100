using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Project002.Startup))]
namespace Project002
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
