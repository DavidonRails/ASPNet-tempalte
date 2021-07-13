using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExquisiteSoftware.Vision.Startup))]
namespace ExquisiteSoftware.Vision
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
