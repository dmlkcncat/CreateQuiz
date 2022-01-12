using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DamlaApi
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
            services.AddCors();
            services.AddControllers();
            services.AddSingleton<IUserService, UserManager>();
            services.AddSingleton<IUserDal, IEFUserDal>();
            services.AddSingleton<IArticleService, ArticleManager>();
            services.AddSingleton<IArticleDal, IEFArticleDal>();
            services.AddSingleton<IExamService, ExamManager>();
            services.AddSingleton<IExamDal, IEFExamDal>();
            services.AddSingleton<IQuestionService, QuestionManager>();
            services.AddSingleton<IQuestionDal, EFQuestionDal>();
            services.AddSingleton<IAnswerService, AnswerManager>();
            services.AddSingleton<IAnswerDal, EFAnswerDal>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseCors(builder=> builder.WithOrigins("http://localhost:4200").AllowAnyHeader());
            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}