namespace TheRedPillAPI
{

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using DataModels.Settings;
using DataAccess.Context;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Options;

    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //Load AppSettings Section For AppSettingsDI with IOptions<AppSettings> settings
            services.Configure<AppSettings>(Configuration.GetSection("AppSettings"));
           
            //Adding two context , one for data on Nosql , second for user on Sql  ( BOTH ON POSTGRESQL )
            services.AddEntityFrameworkNpgsql()
               .AddDbContext<DataAPIContext>(options => options.UseNpgsql(Configuration.GetConnectionString("data")))
               .BuildServiceProvider();
            services.AddEntityFrameworkNpgsql()
               .AddDbContext<UserAPIContext>(options => options.UseNpgsql(Configuration.GetConnectionString("user")))
               .BuildServiceProvider();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
