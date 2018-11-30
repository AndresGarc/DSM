using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SuperPet.Startup))]
namespace SuperPet
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
