using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using ApplicationCore.Services.IServices;
using ApplicationCore.Services.Services;
using FluentValidation.AspNetCore;
using Infra.Data;
using Infra.Repository;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Swashbuckle.AspNetCore.Swagger;
using System;
using System.Text;
using System.Threading.Tasks;

namespace UI
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

            //Swagger
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "API", Version = "V1" });
            });
            //Swagger



            // Servico de compactação
            services.AddResponseCompression();
            // Servico de compactação

            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => false;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });


            services.AddDbContext<ConextoDB>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            //Token
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
           .AddJwtBearer(options =>
           {
               options.TokenValidationParameters = new TokenValidationParameters
               {
                   ValidateIssuer = true,
                   ValidateAudience = true,
                   ValidateLifetime = true,
                   ValidateIssuerSigningKey = true,
                   ValidIssuer = "hamilton.net",
                   ValidAudience = "hamilton.net",
                   IssuerSigningKey = new SymmetricSecurityKey(
                   Encoding.UTF8.GetBytes(Configuration["SecurityKey"]))
               };

               options.Events = new JwtBearerEvents
               {
                   OnAuthenticationFailed = context =>
                   {
                       Console.WriteLine("Token inválido..:. " + context.Exception.Message);
                       return Task.CompletedTask;
                   },
                   OnTokenValidated = context =>
                   {
                       Console.WriteLine("Toekn válido...: " + context.SecurityToken);
                       return Task.CompletedTask;
                   }
               };
           });
            //Token

            services.AddTransient(typeof(IRepositorio<Usuario>), typeof(Repositorio<Usuario>));
            services.AddTransient(typeof(IServices<Usuario>), typeof(ServicoUsuario));

            services.AddTransient(typeof(IRepositorio<Categoria>), typeof(Repositorio<Categoria>));
            services.AddTransient(typeof(IServices<Categoria>), typeof(ServicoCategoria));

            services.AddTransient(typeof(IRepositorio<Produto>), typeof(Repositorio<Produto>));
            services.AddTransient(typeof(IServices<Produto>), typeof(ServicoProduto));

            services.AddTransient(typeof(IRepositorio<Pedido>), typeof(Repositorio<Pedido>));
            services.AddTransient(typeof(IServices<Pedido>), typeof(ServicoPedido));

            services.AddTransient(typeof(IRepositorio<Cliente>), typeof(Repositorio<Cliente>));
            services.AddTransient(typeof(IServices<Cliente>), typeof(ServicoCliente));



            //acrescentado o FluentiValidation
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2).AddFluentValidation(
                 fvc => fvc.RegisterValidatorsFromAssemblyContaining<Startup>());
            //acrescentado o FluentiValidation

            //pwa
            //services.AddProgressiveWebApp(new PwaOptions
            //{
            //    CacheId = "Worker " + version,
            //    Strategy = ServiceWorkerStrategy.CacheFirst,
            //    RoutesToPreCache = "/Home/Contact, /Home/About"

            //    OfflineRoute = "fallBack.html",
            //});

            services.AddProgressiveWebApp();
            //pwa


            //EnabledCORS
            services.AddCors(options =>
            {
                options.AddPolicy("EnabledCORS", builder =>
                {
                    builder.AllowAnyOrigin().AllowAnyMethod().AllowCredentials().Build();
                });
            });
            //EnabledCORS


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
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            //cors
            app.UseCors("EnabledCORS");
            //cors

            //validar a autenticacao
            app.UseAuthentication();
            //validar a autenticacao


            // Ativar a compactação
            app.UseResponseCompression();
            // Ativar a compactação

            //Swagger
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "post API V1");
            });
            //Swagger

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });


        }
    }
}
