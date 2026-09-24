namespace APP.Services.Navigation
{
    internal interface INavigationService
    {
        void NavigateTo<TForm, TPresenter, TArgs>(TArgs? args) where TForm : Form where TPresenter : class;
        Form OpenDialog<TForm, TPresenter, TArgs>(TArgs? args) where TForm : Form where TPresenter : class;
        void SetMainForm(Form form);
    }
}
