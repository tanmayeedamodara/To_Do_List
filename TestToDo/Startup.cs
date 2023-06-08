using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestToDo.Startup))]
namespace TestToDo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
