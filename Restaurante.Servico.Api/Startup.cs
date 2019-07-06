using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Rest.Domain.Interfaces.Repositorys;
using Rest.Domain.Interfaces.Services;
using Rest.Domain.Services;
using Rest.Infra.Data.Repository;
using Rest.Servico.Api.Extensions;

namespace Rest.Servico.Api
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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services.AddTransient<IRestauranteRepository, RestauranteRepository>();
            services.AddTransient<IRestauranteService, RestauranteService>();
            services.AddTransient<IPratoRepository, PratoRepository>();
            services.AddTransient<IPratoService, PratoService>();
            services.ConfigCors();
            services.ConfigureSqlServer(Configuration);
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

            app.UseCors("Policy");
            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
