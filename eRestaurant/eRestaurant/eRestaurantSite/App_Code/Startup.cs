using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(eRestaurantSite.Startup))]
namespace eRestaurantSite
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
