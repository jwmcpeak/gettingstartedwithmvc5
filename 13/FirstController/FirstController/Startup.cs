using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(FirstController.Startup))]

namespace FirstController
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.Use<MyMiddleware>();
            // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=316888
        }
    }
}
