namespace myExpenses
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }



        private void logInButton_Click(object sender, EventArgs e)
        {
            try
            {

                char[] chArray = this.NationalIdBox.Text.ToCharArray();
                int[] numArray = new int[chArray.Length];
                for (int i = 0; i < chArray.Length; i++)
                {
                    numArray[i] = (int)char.GetNumericValue(chArray[i]);
                }
                int num2 = numArray[9];
                switch (this.NationalIdBox.Text)
                {
                    case "0000000000":
                    case "1111111111":
                    case "22222222222":
                    case "33333333333":
                    case "4444444444":
                    case "5555555555":
                    case "6666666666":
                    case "7777777777":
                    case "8888888888":
                    case "9999999999":
                        MessageBox.Show("کد ملی وارد شده صحیح نمی باشد");
                        break;
                }
                int num3 = ((((((((numArray[0] * 10) + (numArray[1] * 9)) + (numArray[2] * 8)) + (numArray[3] * 7)) + (numArray[4] * 6)) + (numArray[5] * 5)) + (numArray[6] * 4)) + (numArray[7] * 3)) + (numArray[8] * 2);
                int num4 = num3 - ((num3 / 11) * 11);
                if ((((num4 == 0) && (num2 == num4)) || ((num4 == 1) && (num2 == 1))) || ((num4 > 1) && (num2 == Math.Abs((int)(num4 - 11)))))
                {

                }
                else
                {
                    MessageBox.Show("کد ملی نامعتبر است");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("لطفا یک عدد 10 رقمی وارد کنید");
            }

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

                MessageBox.Show("!خوش آمدید");
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

        private void NationalIdBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
    }
}