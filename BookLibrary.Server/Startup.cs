using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BookLibrary.Server.Startup))]
namespace BookLibrary.Server
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
