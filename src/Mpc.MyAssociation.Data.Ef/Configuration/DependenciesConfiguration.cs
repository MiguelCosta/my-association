namespace Mpc.MyAssociation.Data.Ef.Configuration
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;
    using Mpc.MyAssociation.Data.Ef.Repositories;
    using Mpc.MyAssociation.Domain.Core;
    using Mpc.MyAssociation.Domain.Core.Repositories;
    using Mpc.MyAssociation.Infrastructure.CrossCutting.Settings;

    public static class DependenciesConfiguration
    {
        public static IServiceCollection ConfigureDataEf(
            this IServiceCollection services,
            AppSettings appSettings)
        {
            services.AddDbContext<AppDbContext>(
                options => options.UseSqlServer(appSettings.DataBaseSettings.ConnectionString));

            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddTransient<IMembersRepository, MembersRepository>();

            return services;
        }
    }
}
