using Blog.Services.FluentValidations;
using Blog.Services.Services.Abstraction;
using Blog.Services.Services.Concrate;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using FluentValidation;
using System.Globalization;
using Microsoft.AspNetCore.Http;
namespace Blog.Services.Extensions
{
    public static class ServiceLayerExtension
    {
        public static IServiceCollection LoadServiceLayerExtension(this IServiceCollection services)
        {
            var assembly = Assembly.GetExecutingAssembly();
            services.AddScoped<IArticleService, ArticleService>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();


            services.AddAutoMapper(assembly);
            services.AddValidatorsFromAssemblyContaining<ArticleValidator>();

            // Türkçe hata mesajlarını etkinleştirme
            ValidatorOptions.Global.LanguageManager.Enabled = true;
            ValidatorOptions.Global.LanguageManager.Culture = new CultureInfo("tr");

         //   services.AddControllersWith()
         //.AddFluentValidation(fv =>
         //{
         //    fv.RegisterValidatorsFromAssemblyContaining<ArticleValidator>();
         //    fv.RunDefaultMvcValidationAfterFluentValidationExecutes = false;
         //});



            return services;
        }
    }
}
