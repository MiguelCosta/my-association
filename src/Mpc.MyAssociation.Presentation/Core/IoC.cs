using System.Configuration;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using Mpc.MyAssociation.Application.Services.Configuration;
using Mpc.MyAssociation.Data.Ef.Configuration;
using Mpc.MyAssociation.Infrastructure.CrossCutting.Settings;

namespace Mpc.MyAssociation.Presentation.Core
{
    public static class IoC
    {
        private static ServiceProvider ServiceProvider = null;

        public static T GetForm<T>() where T : Form
        {
            return ServiceProvider.GetRequiredService<T>();
        }

        public static void Init()
        {
            var services = new ServiceCollection();
            RegisterForms(services);

            var appSettings = new AppSettings
            {
                DataBaseSettings = new DataBaseSettings
                {
                    ConnectionString = ConfigurationManager.AppSettings["DataBaseConnectionString"]
                }
            };

            services.ConfigureApplicationServices(appSettings);
            services.ConfigureDataEf(appSettings);

            ServiceProvider = services.BuildServiceProvider();
        }

        private static void RegisterForms(IServiceCollection services)
        {
            services.AddSingleton<FrmMain>();
            services.AddTransient<FormsMembers.FrmMemberList>();
        }
    }
}
