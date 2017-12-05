using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Serilog;
using UdaStore.Client.Core;
using UdaStore.Client.Core.Extensions;
using UdaStore.Client.Persistence;

namespace UdaStore.Client
{
    public class Startup
    {
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly IConfiguration _configuration;

        public Startup(IConfiguration configuration, IHostingEnvironment env)
        {
            _configuration = configuration;
            _hostingEnvironment = env;
        }
        

        // This method gets called by the runtime. Use this method to add services to the container.
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IUdaStoreDbContext, UdaStoreDbContext>();
            services.AddDbContext<UdaStoreDbContext>(options =>
            options.UseSqlServer(_configuration.GetConnectionString("UdaStoreDatabase"),
                paging => paging.UseRowNumberForPaging()));

            services.AddCustomizedAuthentication(_configuration);
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            return services.Build(_configuration, _hostingEnvironment);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            if (env.IsDevelopment())
            {
                loggerFactory.WithFilter(new FilterLoggerSettings
                    {
                        { "Microsoft", LogLevel.Warning },
                        { "System", LogLevel.Warning },
                        { "UdaStore", LogLevel.Debug }
                    })
                    .AddConsole()
                    .AddSerilog();

                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                loggerFactory.WithFilter(new FilterLoggerSettings
                    {
                        { "Microsoft", LogLevel.Warning },
                        { "System", LogLevel.Warning },
                        { "UdaStore", LogLevel.Error }
                    })
                    .AddSerilog();

                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();
            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
