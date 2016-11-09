using WebApplication2.Filters;

namespace WebApplication2
{
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Logging;
    using WebApplication1.Services;
    using WebApplication1.Services.Contracts;

    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(x => x.Filters.Add(new ExceptionFilter()));

            RegisterDependencies(services);
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }

        private static void RegisterDependencies(IServiceCollection services)
        {
            services.AddTransient<IValuesService, ValuesService>();
        }
    }
}