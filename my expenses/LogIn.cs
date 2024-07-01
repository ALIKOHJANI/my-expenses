namespace my_expenses
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }



        private void logInButton_Click(object sender, EventArgs e)
        {

            string nationalCode = NationalIdBox.Text;
            string password = PasswordBax.Text;

            bool isValid = false;
            foreach (User item in Data.Users)
            {
                if (item.NationalId == nationalCode && item.Password == password)
                {
                    isValid = true;
                    break;
                }
            }

            if (isValid)
            {

                MessageBox.Show("خوش آمدید!");
                MainPage mainPage = new MainPage();
                mainPage.Show();
                this.Hide();
            }
            else
            {

                MessageBox.Show("شماره ملی و رمز ورود وارد شده وجود ندارد.");
            }


        }

        private void ForgotPasswordButton_Click(object sender, EventArgs e)
        {
            ForgotPassword forgotPassword = new ForgotPassword();
            forgotPassword.Show();
            this.Hide();

        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();

        }

       
    }
}