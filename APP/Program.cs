using APP.Presenters.Main;
using APP.Presenters.Register;
using APP.Services.Navigation;
using APP.Services.Navigation.Factory;
using APP.Views.Main;
using APP.Views.Register;
using Microsoft.Extensions.DependencyInjection;

namespace APP
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            var service = new ServiceCollection();

            ConfigureServices(service);

            using (var serviceProvider = service.BuildServiceProvider())
            {
                ApplicationConfiguration.Initialize();

                var mainForm = serviceProvider.GetRequiredService<MainForm>();
                serviceProvider.GetRequiredService<MainPresenter>();
                Application.Run(mainForm);
            }
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            //Container
            services.AddSingleton<MainForm>();

            //Views
            services.AddTransient<RegisterForm>();

            //Presenters
            services.AddSingleton<MainPresenter>();
            services.AddTransient<RegisterPresenter>();

            //Interfaces
            services.AddTransient<IRegisterView>(sp => sp.GetRequiredService<RegisterForm>());
            services.AddSingleton<IMainView>(sp => sp.GetRequiredService<MainForm>());

            //Services
            services.AddSingleton<INavigationService, NavigationService>();
            services.AddSingleton<IFormFactory, FormFactory>();

        }
    }
}