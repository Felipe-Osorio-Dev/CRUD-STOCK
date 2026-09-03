namespace APP.Services.Navigation.Factory
{
    internal interface IFormFactory
    {
        Form CreateForm<TForm, TPresenter>() where TForm : Form where TPresenter : class;
        Form CreateForm<TForm, TPresenter, TArgs>(TArgs args) where TForm : Form where TPresenter : class;
    }
}
