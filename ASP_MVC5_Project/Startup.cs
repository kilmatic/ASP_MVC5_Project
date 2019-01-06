using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASP_MVC5_Project.Startup))]
namespace ASP_MVC5_Project
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
