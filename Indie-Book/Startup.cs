using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Indie_Book.Startup))]
namespace Indie_Book
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
