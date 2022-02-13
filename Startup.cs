using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FreshFruitsStore.Startup))]
namespace FreshFruitsStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
