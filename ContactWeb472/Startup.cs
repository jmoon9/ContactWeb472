using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ContactWeb472.Startup))]
namespace ContactWeb472
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
