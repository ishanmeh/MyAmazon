using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyAmazon.Startup))]
namespace MyAmazon
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
