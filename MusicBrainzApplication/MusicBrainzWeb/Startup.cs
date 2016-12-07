using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MusicBrainzWeb.Startup))]
namespace MusicBrainzWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
