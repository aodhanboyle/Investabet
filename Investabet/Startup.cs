using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Investabet.Startup))]
namespace Investabet
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
