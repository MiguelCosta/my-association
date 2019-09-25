namespace Mpc.MyAssociation.Application.Services.Configuration
{
    using Microsoft.Extensions.DependencyInjection;
    using Mpc.MyAssociation.Application.Services.Abstractions;
    using Mpc.MyAssociation.Application.Services.Implementations;
    using Mpc.MyAssociation.Infrastructure.CrossCutting.Settings;

    public static class DependenciesConfiguration
    {
        public static IServiceCollection ConfigureApplicationServices(
            this IServiceCollection services,
            AppSettings appSettings)
        {
            services.AddTransient<IMembersService, MembersService>();
            services.AddTransient<IQuotasService, QuotasService>();

            return services;
        }
    }
}
