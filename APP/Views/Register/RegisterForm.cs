using APP.Dtos.Requests;
using APP.Util.CustomArgs;

namespace APP.Views.Register
{
    public partial class RegisterForm : Form, IRegisterView
    {
        public RegisterForm()
        {
            InitializeComponent();

            btnRegister.Enabled = false;

            dateTimeValidate.MinDate = DateTime.Now.AddMonths(3);

            txtBoxName.TextChanged += IsEnabled;

            txtBoxEan.TextChanged += IsEnabled;
            txtBoxEan.KeyPress += OnValidateEan;
        }

        public event EventHandler<CustomEventArgs<RegisterProductDTO>> RegisterClicked;

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var product = new RegisterProductDTO
            {
                Name = txtBoxName.Text,
                Ean = txtBoxEan.Text,
                Amount = (int) numericAmount.Value,
                Validate = DateOnly.FromDateTime(dateTimeValidate.Value)
            };

            RegisterClicked?.Invoke(this, new CustomEventArgs<RegisterProductDTO>(product));
        }

        private void IsEnabled(object sender, EventArgs e)
        {
            btnRegister.Enabled = !string.IsNullOrWhiteSpace(txtBoxName.Text) && !string.IsNullOrWhiteSpace(txtBoxEan.Text);
        }

        private void OnValidateEan(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
