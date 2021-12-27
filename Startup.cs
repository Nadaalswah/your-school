using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(your_school.Startup))]
namespace your_school
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
