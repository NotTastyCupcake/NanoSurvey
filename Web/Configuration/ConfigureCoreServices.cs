using NotTastyCupcake.NanoSurvey.ApplicationCore.Interfaces;
using NotTastyCupcake.NanoSurvey.Web.Interfaces;
using NotTastyCupcake.NanoSurvey.Web.Services;
using NotTastyCupcake.NanoSurvey.DataAccess;

namespace NotTastyCupcake.NanoSurvey.Web.Configuration
{
    public static class ConfigureCoreServices
    {
        public static IServiceCollection AddCoreServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped(typeof(IReadOnlyRepository<>), typeof(EfRepository<>));
            services.AddScoped(typeof(IRepository<>), typeof(EfRepository<>));

            services.AddScoped<IQuestionViewModelService, QuestionViewModelService>();

            return services;
        }
    }
}
