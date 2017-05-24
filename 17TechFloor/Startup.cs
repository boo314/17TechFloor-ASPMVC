using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_17TechFloor.Startup))]
namespace _17TechFloor
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
