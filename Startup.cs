using Microsoft.AspNet.Builder;
using Microsoft.Framework.Logging;

namespace HelloWeb
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole();
            app.UseStaticFiles();
           //app.UseWelcomePage();
        //    app.UseWelcomePage();
            // changes done
            //app .UseWelcomepage()

            //app.UseWelcomePage();


         //  do chanages again and Commmit that changes.
            app.UseWelcomePage();


        }
    }
}
