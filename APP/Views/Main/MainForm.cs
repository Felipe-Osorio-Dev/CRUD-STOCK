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
        public event EventHandler StockMenuItemClicked;

        private void registerMenuItem_Click(object sender, EventArgs e)
        {
            RegisterMenuItemClicked?.Invoke(this, EventArgs.Empty);
        }

        private void stockMenuItem_Click(object sender, EventArgs e)
        {
            StockMenuItemClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
