using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Vidly_Mosh_KZK.Startup))]
namespace Vidly_Mosh_KZK
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
