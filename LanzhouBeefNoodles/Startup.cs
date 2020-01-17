using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using LanzhouBeefNoodles.Models;
using Microsoft.EntityFrameworkCore;//56.引用EFCore
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Identity;

namespace LanzhouBeefNoodles
{
    public class Startup
    {
        //59.为了使用connectionString
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //57.注入AppDbContext->AppSeting.json                              60.用Configuration使用connectionString                   
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddMvc();//1                     64.替换为真数据仓库->DbInitializer.cs
            services.AddHttpClient();//2019-12-23为了解决addHeader添加的（可删）
            services.AddTransient<INoodleRepository, NoodleRepository>();//21->Homecontroller.cs
            services.AddTransient<IFeedbackRepository, FeedbackRepository>();//31->HomeViewModel.cs
            services.AddTransient<INewRepository, NewRepository>();
            services.AddTransient<INoticeRepository, NoticeRepository>();
            services.AddTransient<ILinkRepository, LinkRepository>();


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();//美化主页

            //身份认证中间件
            app.UseAuthentication();

            //3
            // app.UseMvcWithDefaultRoute();
            //6  在这里修改为首页的视图
            app.UseMvc(route=> {
                route.MapRoute("default","{controller=Default}/{action=One}/{id?}");
            });

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            });
            //不会执行
        }
    }
}
