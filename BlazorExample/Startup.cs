using BlazorExample.Services;
using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorExample
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.Add(ServiceDescriptor.Singleton(new GeradorDeNumeros()));
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}
