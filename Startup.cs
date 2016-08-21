using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(tick_tack_toe.Startup))]
namespace tick_tack_toe
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
        }
    }
}
