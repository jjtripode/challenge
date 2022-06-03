using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.Swagger;
using nubimetricsApi.Data;
using nubimetricsApi.Mapping;
using nubimetricsApi.Services;

namespace transportePublicoApi
{
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
            services.AddDbContextPool<ApplicationDbContext>(opt =>
            {
                opt.UseSqlServer(
                    Configuration.GetConnectionString("nubimetricsDBConnectionLocal")
                        , options =>
                        {
                            options.UseRowNumberForPaging();
                        }
                    );
            }
            );

            services.AddScoped<IPaisesService, PaisesService>();
            services.AddScoped<IProductosService, ProductosService>();

            services.AddAutoMapper(
                typeof(ModelToResponseProfile),
                typeof(RequestToModelProfile)
                );

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info
                {
                    Version = "v1.1",
                    Title = "Transporte API",
                    Description = "Api Transporte Substes, Trenes, Colectivos",
                    TermsOfService = "https://example.com/terms",
                    Contact = new Contact
                    {
                        Name = "Juan",
                        Email = "Juan@mail.com",
                        Url = "https://twitter.com/jjtripode@hotmail.com",
                    },
                    License = new License
                    {
                        Name = "Use under LICX",
                        Url = "https://example.com/license",
                    }
                });

                // Set the comments path for the Swagger JSON and UI.
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                c.CustomSchemaIds(x => x.FullName);
                c.IncludeXmlComments(xmlPath);

            });
            services.AddCors(options =>
            {
                options.AddPolicy("AllowAllOrigin",
                    builder => builder.AllowAnyOrigin());
            });

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

            app.UseSwagger();
            app.UseCors();
            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.

            app.UseSwaggerUI(c =>
                    {
            #if DEBUG
                        // For Debug in Kestrel
                        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Web API V1");
            #else
                        // To deploy on IIS
                        //c.SwaggerEndpoint("/swagger/swagger.json", "Web API V1.1");
                        c.SwaggerEndpoint("/swagger.json", "Web API V1.1");
            #endif
                        c.RoutePrefix = string.Empty;
                    });


            app.UseHttpsRedirection();

            app.UseMvc();
        }
    }
}
