using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExcellaWorld.Startup))]
namespace ExcellaWorld
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
