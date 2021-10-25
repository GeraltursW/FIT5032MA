using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FIT5032MA.Startup))]
namespace FIT5032MA
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}
