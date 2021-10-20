using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Demo12.Data;
using Demo12.Services;
using Demo12.Services.Database;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Demo12
{
    public class Startup
    {
        // 1. Add property to hold Config
        public IConfiguration Configuration { get; }

        // 2. Magic to get an IConfiguration from somewhere
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<SchoolDbContext>(options => {
                // Our process.env.DATABASE_URL from js days
                string connectionString = Configuration.GetConnectionString("DefaultConnection");

                // Use that connection string with SQL Server
                options.UseSqlServer(connectionString);
            });

            // Make sure MVC knows about our Controllers
            services.AddControllers();

            // Our services!
            services.AddSingleton<IStudentRepository, DatabaseStudentRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                // Use MVC to handle endpoints, first
                endpoints.MapControllers();

                // app.get("/", ....)
                endpoints.MapGet("/", async context =>
                {
                    var req = context.Request;
                    var res = context.Response;

                    await context.Response.WriteAsync("Hello World!");
                });

                endpoints.MapGet("/hi", async context =>
                {
                    await context.Response.WriteAsync("Hi!!!!!");
                });

                endpoints.MapGet("/500", async context =>
                {
                    throw new ApplicationException("Boom!");
                });
            });
        }
    }
}
