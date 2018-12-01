using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NorthwindRestApi.RestApi.Startup))]
namespace NorthwindRestApi.RestApi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
