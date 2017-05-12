using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC5Authentication_Hayley.Startup))]
namespace MVC5Authentication_Hayley
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
