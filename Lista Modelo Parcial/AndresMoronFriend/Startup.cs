using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AndresMoronFriend.Startup))]
namespace AndresMoronFriend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
