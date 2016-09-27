using System.Linq;

namespace MyApplication
{
    public partial class LoginForm : Infrastructure.BaseForm
    {
        public LoginForm()
            : base()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, System.EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, System.EventArgs e)
        {
            if ((string.IsNullOrWhiteSpace(UsernameTextBox.Text)) || 
                (string.IsNullOrWhiteSpace(PasswordTextBox.Text)))
            {
                System.Windows.Forms.MessageBox.Show("Username and Password is requied!");
                return;

            }
            Models.DatabaseContext oDatabaseContext = null;
            try
            {
                oDatabaseContext =
                    new Models.DatabaseContext();


            }
            catch (System.Exception)
            {
                
                
            }

        }
    }
}
