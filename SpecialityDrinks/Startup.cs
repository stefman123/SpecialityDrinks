using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SpecialityDrinks.Startup))]
namespace SpecialityDrinks
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
