using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(XEx03Quotation.Startup))]
namespace XEx03Quotation
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
