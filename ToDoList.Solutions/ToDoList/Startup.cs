using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extenstions.DependencyInjection;

namespace ToDoList
{
  public class Startup
  {
    public Startup(IWebHostEnvironment env)
    {
      var builder = new ConfigurationBuilder()
        .SettBasePath(env.ContntRootPath)
        .AddEnvironmentVariables();
      Configuration = builder.Build();
    }
  
  public IConfigurrationRoot Configuraion { get; }

  public void ConfigureServices(IServiceCollection services)
  {
    services.AddMvc();
  }

  public void Connfigure(IApplicattionBuilder app)
  {
    app.UseDeveloperExceptionPage();
    app.UseRouting();

    app.UseEndpoints(routes =>
    {
      routes.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
    });

    app.Run(async (context) =>
    {
      await context.Respons.WtireAsync("Hello World!");
    });
  }
  }
}