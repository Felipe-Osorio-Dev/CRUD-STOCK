using APP.Dtos.Requests;
using APP.Dtos.Responses;
using APP.Util.CustomArgs;

namespace APP.Views.Register
{
    public partial class RegisterForm : Form, IRegisterView
    {

        public RegisterForm()
        {
            InitializeComponent();

            btnRegister.Enabled = false;
            btnSaveEdit.Visible = false;

            dateTimeValidate.MinDate = DateTime.Now.AddMonths(3);

            txtBoxName.TextChanged += IsEnabled;

            txtBoxEan.TextChanged += IsEnabled;
            txtBoxEan.KeyPress += OnValidateEan;
        }
        public RegisterForm(ProductDTO product)
        {
            InitializeComponent();
            OnEditProduct(product);

            btnRegister.Visible = false;

            btnSaveEdit.Visible = true;

            dateTimeValidate.MinDate = DateTime.Now.AddMonths(3);

            txtBoxEan.KeyPress += OnValidateEan;

            txtBoxName.TextChanged += (s, e) =>
            {
                if(txtBoxName.Text != product.Name)
                {
                    EditedProduct.Name = txtBoxName.Text;
                }
                
            };

            txtBoxEan.TextChanged += (s, e) =>
            {
                if (txtBoxEan.Text != product.Ean)
                {
                    EditedProduct.Ean = txtBoxEan.Text;
                }
            };

            numericAmount.ValueChanged += (s, e) =>
            {
                if (numericAmount.Value != product.Amount)
                {
                    EditedProduct.Amount = (int)numericAmount.Value;
                }
            };

            dateTimeValidate.ValueChanged += (s, e) =>
            {
                if (dateTimeValidate.Value != product.Validate.ToDateTime(TimeOnly.MinValue))
                {
                    EditedProduct.Validate = DateOnly.FromDateTime(dateTimeValidate.Value);
                }
            };
        }

        public ProductDTO CreatedProduct { get; set; } = new();
        public DialogResult DialogResult { get; set; }
        public EditProductDTO EditedProduct { get; set; } = new();

        public event EventHandler<CustomEventArgs<RegisterProductDTO>> RegisterClicked;
        public event EventHandler<CustomEventArgs<EditProductDTO>> SaveEditClicked;

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var product = new RegisterProductDTO
            {
                Name = txtBoxName.Text,
                Ean = txtBoxEan.Text,
                Amount = (int)numericAmount.Value,
                Validate = DateOnly.FromDateTime(dateTimeValidate.Value)
            };

            RegisterClicked?.Invoke(this, new CustomEventArgs<RegisterProductDTO>(product));

            btnRegister.DialogResult = DialogResult;
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

        private void OnEditProduct(ProductDTO product)
        {
            txtBoxName.Text = product.Name;
            txtBoxEan.Text = product.Ean;
            numericAmount.Value = product.Amount;
            dateTimeValidate.Value = product.Validate.ToDateTime(TimeOnly.MinValue);
        }

        private void btnSaveEdit_Click(object sender, EventArgs e)
        {
            SaveEditClicked?.Invoke(this, new CustomEventArgs<EditProductDTO>(EditedProduct));

            btnSaveEdit.DialogResult = DialogResult;
        }
    }
}
