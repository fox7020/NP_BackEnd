using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NP_BackEnd.Startup))]
namespace NP_BackEnd
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
