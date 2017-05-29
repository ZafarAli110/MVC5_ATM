using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC5_ATM.Startup))]
namespace MVC5_ATM
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
