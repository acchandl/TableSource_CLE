using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TableSource_CLE.Startup))]
namespace TableSource_CLE
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
