using Application.Services;
using Application.Services.Cryptography;
using Application.Services.TokenServices;
using Application.useCases.Products;
using Application.UseCases.Products;
using Application.UseCases.Users;
using Domain.IRepositories;
using Infra.Context;
using Infra.Repositories;
using Infra.Repositorios;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;

namespace API
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
            //Dependencies Inversions
            services.AddControllers();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<ICreateNewProduct, CreateNewProduct>();
            services.AddScoped<IDeleteProduct, DeleteProduct >();
            services.AddScoped<IListAllProducts, ListAllProducts>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<ICreateNewUser, CreateNewUser>();
            services.AddScoped<IDeleteUser, DeleteUser>();
            services.AddScoped<IListAllUsers, ListAllUsers>();
            services.AddScoped<IUserLogin, UserLogin>();
            services.AddScoped<ICriptography, Criptography>();
            services.AddScoped<ISettings, Settings>();
            services.AddScoped<ITokenService, TokenService>();

            //Swagger
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "API", Version = "v1" });
            });

            //DbContext Configuration
            services.AddDbContext<StoreContext>(context=>context.UseSqlite(Configuration.GetConnectionString("Default")));
            ISettings _settings = new Settings();

            //AuthConfiguration
            var key = Encoding.ASCII.GetBytes(_settings.Secret);
            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(jwt=> 
            {
                jwt.RequireHttpsMetadata = false;
                jwt.SaveToken = true;
                jwt.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,//Valida��o de chave
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer=false,
                    ValidateAudience = false
                };
            });
           
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "API v1"));
            }

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
