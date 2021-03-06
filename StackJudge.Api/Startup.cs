using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using StackJudge.Filters;
using StackJudgeCore.Company.Repositories;
using StackJudgeCore.Company.Services;
using StackJudgeEf;
using StackJudgeEf.Repositories;
using StackJudgeEf.Service;

namespace StackJudge
{
    public class Startup
    {
        public readonly string MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        private IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(c =>  
            {  
                c.AddPolicy("AllowOrigin", options => options.AllowAnyOrigin());  
            }); 
            
            services.AddControllers();

            services.AddScoped<ICompanyService, CompanyService>();
            services.AddScoped<ICompanyRepository, CompanyRepository>();

            services.AddScoped<IAddressService, AddressService>();
            services.AddScoped<IAddressRepository, AddressRepository>();

            services.AddScoped<IStackService, StackService>();
            services.AddScoped<IStackRepository, StackRepository>();

            services.AddScoped<ITransactionRunnerService, TransactionRunnerService>();
            
            services.AddMvc(options =>
                {
                    options.Filters.Add(typeof(ValidateModelStateAttribute));
                })
                .AddFluentValidation(fvc => fvc.RegisterValidatorsFromAssemblyContaining<Startup>());

            services.Configure<ApiBehaviorOptions>(options =>
            {
                options.SuppressModelStateInvalidFilter = true;
            });

            services.AddDbContext<AppDbContext>(
                option => { option.UseNpgsql(Configuration.GetConnectionString("DefaultConnection")); }
            );
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // app.UseHttpsRedirection();

            app.UseRouting();
            
            app.UseCors(options => options.WithOrigins("http://localhost:4200").AllowCredentials());  

            app.UseAuthorization();

            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
        }
    }
}
