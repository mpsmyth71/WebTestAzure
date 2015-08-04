using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AzureMVCWebDemo.Startup))]
namespace AzureMVCWebDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
