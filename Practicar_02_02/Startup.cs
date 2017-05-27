using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Practicar_02_02.Startup))]
namespace Practicar_02_02
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
