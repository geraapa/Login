using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Loguin1.Startup))]
namespace Loguin1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
