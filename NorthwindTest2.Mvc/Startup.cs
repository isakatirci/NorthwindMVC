using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NorthwindTest2.Mvc.Startup))]
namespace NorthwindTest2.Mvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
