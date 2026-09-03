using APP.Views.Main;

namespace APP
{
    public partial class MainForm : Form, IMainView
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public event EventHandler RegisterMenuItemClicked;

        private void registerMenuItem_Click(object sender, EventArgs e)
        {
            RegisterMenuItemClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
