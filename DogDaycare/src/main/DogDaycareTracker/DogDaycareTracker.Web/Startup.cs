using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DogDaycareTracker.Web.Startup))]
namespace DogDaycareTracker.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
