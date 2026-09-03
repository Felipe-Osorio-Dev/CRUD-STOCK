using Microsoft.Extensions.DependencyInjection;

namespace APP.Services.Navigation.Factory
{
    internal class FormFactory : IFormFactory
    {
        private readonly IServiceProvider _serviceProvider;

        public FormFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public Form CreateForm<TForm, TPresenter>()
            where TForm : Form
            where TPresenter : class
        {
            var form = _serviceProvider.GetRequiredService<TForm>();
            ActivatorUtilities.CreateInstance<TPresenter>(_serviceProvider, form);

            return form;
        }

        public Form CreateForm<TForm, TPresenter, TArgs>(TArgs args)
            where TForm : Form
            where TPresenter : class
        {
            var form = ActivatorUtilities.CreateInstance<TForm>(_serviceProvider, args!);
            ActivatorUtilities.CreateInstance<TPresenter>(_serviceProvider, form);

            return form;
        }
    }
}
