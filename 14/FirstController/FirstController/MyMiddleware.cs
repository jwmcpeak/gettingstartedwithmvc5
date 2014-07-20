using Microsoft.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace FirstController
{
    public class MyMiddleware : OwinMiddleware
    {
        public MyMiddleware(OwinMiddleware next) : base(next) { }
        public async override Task Invoke(IOwinContext context)
        {
            //context.Response.Write("This is before MVC.");
            await Next.Invoke(context);
            //context.Response.Write("This is after MVC.");
        }
    }
}