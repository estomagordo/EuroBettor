using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EuroBettor.Startup))]
namespace EuroBettor
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
