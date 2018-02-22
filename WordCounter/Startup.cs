using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace WordCounter
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app)
<<<<<<< HEAD
          {
            app.UseDeveloperExceptionPage();
=======
        {
          app.UserDeveloperExceptionPage();
>>>>>>> 60972039a99c1d7d590da6871464a7acd8f09534
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
            app.Run(async (context) =>
            {
<<<<<<< HEAD
                await context.Response.WriteAsync("ONE LOVE!");
=======
                await context.Response.WriteAsync("One Love!.");
>>>>>>> 60972039a99c1d7d590da6871464a7acd8f09534
            });
        }
    }
}
