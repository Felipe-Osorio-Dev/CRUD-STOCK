using APP.Services.Navigation.Factory;

namespace APP.Services.Navigation
{
    internal class NavigationService : INavigationService
    {
        private readonly IFormFactory _formFactory;
        private Form? _mainForm;

        public NavigationService(IFormFactory formFactory)
        {
            _formFactory = formFactory;
        }

        public void NavigateTo<TForm, TPresenter>()
            where TForm : Form
            where TPresenter : class
        {
            
            if(_mainForm == null)
            {
                throw new InvalidOperationException("Container Principal da Aplicação não está definido.");
            }

            var existingForm = _mainForm.MdiChildren.FirstOrDefault(f => f is TForm);

            if(existingForm != null)
            {
                existingForm.Activate();
                return;
            }

            var form = _formFactory.CreateForm<TForm, TPresenter>();
            form.MdiParent = _mainForm;
            form.Show();
        }

        public void NavigateTo<TForm, TPresenter, TArgs>(TArgs args)
            where TForm : Form
            where TPresenter : class
        {
            throw new NotImplementedException();
        }

        public void SetMainForm(Form form)
        {
            _mainForm = form;
        }
    }
}
