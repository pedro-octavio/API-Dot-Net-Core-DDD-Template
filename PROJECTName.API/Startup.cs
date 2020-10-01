using Autofac;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PROJECTName.Application.Mappers;
using PROJECTName.Infra.Data;
using PROJECTName.Infra.IOC;

namespace PROJECTName.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration) => Configuration = configuration;

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers().AddNewtonsoftJson();

            services.AddCors(cors => cors.AddPolicy("ExamplePolicy", builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader()));

            services.AddDbContext<DataContext>(options => options.UseMySql(Configuration["ConnectionStrings:PROJECTNameDB"], x => x.MigrationsAssembly("PROJECTName.API")));

            services.AddAutoMapper(typeof(MappingProfile));
        }

        public void ConfigureContainer(ContainerBuilder builder) => builder.RegisterModule(new ModuleIOC());

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment()) app.UseDeveloperExceptionPage();

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints => endpoints.MapControllers());

            app.UseCors("ExamplePolicy");
        }
    }
}
