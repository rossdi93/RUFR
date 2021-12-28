using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using React.AspNet;
using JavaScriptEngineSwitcher.ChakraCore;
using JavaScriptEngineSwitcher.Extensions.MsDependencyInjection;
using Api.DataLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using RUFR.Api.Service.Interfaces;
using RUFR.Api.Service.Services;
using RUFR.Api.DataLayer;

namespace RUFR.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllersWithViews(mvcOptions =>
            {
                mvcOptions.EnableEndpointRouting = false;
            });

            services.AddCors();

            services.AddMvc().SetCompatibilityVersion(Microsoft.AspNetCore.Mvc.CompatibilityVersion.Version_3_0)
                .AddNewtonsoftJson(options => options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.AddReact();
            services.AddJsEngineSwitcher(options => options.DefaultEngineName = ChakraCoreJsEngine.EngineName).AddChakraCore();
            services.AddDbContext<ApiDbContext>(o => o.UseNpgsql(Configuration.GetConnectionString("DefaultConnection")));
            services.AddScoped<IDbContext, ApiDbContext>();
            services.AddScoped<INewsService, NewsService>();
            services.AddScoped<IHistoryOfSuccessService, HistoryOfSuccessService>();
            services.AddScoped<IProjectService, ProjectService>();
            services.AddScoped<IUsersService, UsersService>();
            services.AddScoped<IEventsService, EventService>();
            services.AddScoped<ITyperOfCooperationService, TyperOfCooperationService>();
            services.AddScoped<IPriorityDirectionService, PriorityDirectionService>();
            services.AddScoped<IMemberService, MemberService>();
            services.AddScoped<IDocumentService, DocumentService>();
            services.AddScoped<IMemberPriorityService, MemberPriorityService>();
            services.AddScoped<IProjectPriorityService, ProjectPriorityService>();
            services.AddScoped<IMemberTypesOfCooperationService, MemberTypesOfCooperationService>();
            services.AddScoped<IProjectMemberService, ProjectMemberService>();
            services.AddScoped<IStatisticalInformationService, StatisticalInformationService>();
            services.AddScoped<ITyperOfCooperationService, TyperOfCooperationService>();
            services.AddScoped<IUserDocumentService, UserDocumentService>();
            services.AddScoped<IUserMemberService, UserMemberService>();
            services.AddScoped<IUserProjectService, UserProjectService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
          
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseRouting();

            // Use the CORS policy
            app.UseCors(builder => builder
            .AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader());

            app.UseHttpsRedirection();
            app.UseReact(config => { });
            app.UseMvc();
        }
    }
}
