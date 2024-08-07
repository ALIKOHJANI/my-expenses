﻿using System.Globalization;
using System.Windows.Forms;

namespace myExpenses
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        User user = new User("علی", "کوهجانی", "Aa13801380", "0481110208");
        ExpnsesServis Servis = new ExpnsesServis();
        private void Entrybutton_Click(object sender, EventArgs e)
        {
            bool isValid = true;

            foreach (Control control in this.Controls)
            {
                if (control is TextBox && control.Name.EndsWith("Box"))
                {

                    TextBox textBox = (TextBox)control;
                    string TextBax = textBox.Text;
                    for (int i = 0; i < this.Controls.Count; i++)
                    {
                        if (Controls[i] is TextBox)
                        {
                            if (string.IsNullOrEmpty((Controls[i] as TextBox).Text))
                            {
                                isValid = false;
                                (Controls[i] as TextBox).BackColor = Color.Red;
                            }
                        }

                    }

                    for (int i = 0; i < this.Controls.Count; i++)
                    {
                        if (Controls[i] is MaskedTextBox)
                        {
                            if (string.IsNullOrEmpty((Controls[i] as MaskedTextBox).Text))
                            {
                                isValid = false;
                                (Controls[i] as MaskedTextBox ).BackColor = Color.Red;
                            }
                        }

                    }
                    foreach (User item in Data.Users)
                    {
                        if (item.NationalId == NationalIdBox.Text)
                        {
                            isValid = false;
                            MessageBox.Show("کد ملی تکراری میباشد لطفا کد ملی را درست وارد کنید ");
                        }
                        else
                        {

                        }
                    }
                    string birthDateText = DateOfBirthBox.Text;
                    DateTime birthDate;
                    if (DateTime.TryParseExact(birthDateText, "yyyy/MM/dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out birthDate))
                    {
                        
                       
                    }
                    else
                    {
                        MessageBox.Show("تاریخ تولد را درست وارد کنید");
                        label1.Visible = false;


                    }

                }
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
                            label1.Text = "کد ملی وارد شده صحیح نمی باشد";
                            break;
                    }
                    int num3 = ((((((((numArray[0] * 10) + (numArray[1] * 9)) + (numArray[2] * 8)) + (numArray[3] * 7)) + (numArray[4] * 6)) + (numArray[5] * 5)) + (numArray[6] * 4)) + (numArray[7] * 3)) + (numArray[8] * 2);
                    int num4 = num3 - ((num3 / 11) * 11);
                    if ((((num4 == 0) && (num2 == num4)) || ((num4 == 1) && (num2 == 1))) || ((num4 > 1) && (num2 == Math.Abs((int)(num4 - 11)))))
                    {
                        label1.Text = ("کد ملی صحیح می باشد");
                    }
                    else
                    {
                        label1.Text = ("کد ملی نامعتبر است");
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("لطفا یک عدد 10 رقمی وارد کنید");
                }
                break;
            }

            if (isValid)
            {
                Data.Users.Add(user);
                LogIn logIn = new LogIn();
                logIn.Show();
                this.Hide();
                MessageBox.Show("کاربر باموفقیت ثبت شد ");
            }
            else
            {
                MessageBox.Show(
                "فیلدها را پرنمایید!",
                "خالی بودن فیلد",
                MessageBoxButtons.OK,
                MessageBoxIcon.Asterisk);
            }

        }

        private void FirtsNameBox_TextChanged(object sender, EventArgs e)
        {

            user.FirtsName = FirtsNameBox.Text;
        }

        private void LastNameBox_TextChanged(object sender, EventArgs e)
        {

            user.LastName = LastNameBox.Text;
        }



        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {
            if (PasswordBox.Text.Length < 8)
            {
                label1.Text = "پسورد باید حداقل ۸ کاراکتر داشته باشد.";
                label1.Visible = true;
            }
            else
            {
                label1.Visible = false;
            }

            user.Password = PasswordBox.Text;
        }







        private void GenderButtonMan_CheckedChanged(object sender, EventArgs e)
        {

            if (GenderButtonMan.Checked)
            {
                user.Gender = GenderButtonMan.Text;
            }
        }

        private void GenderButtonWoman_CheckedChanged(object sender, EventArgs e)
        {

            if (GenderButtonWoman.Checked)
            {
                user.Gender = GenderButtonWoman.Text;

            }
        }

        private void ComingBackButton_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Register_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        private void NationalIdBox_TextChanged(object sender, EventArgs e)
        {
            user.NationalId = NationalIdBox.Text;

        }

        private void DateOfBirthBox_TextChanged(object sender, EventArgs e)
        {
            bool isValid = false;
            string birthDateText = DateOfBirthBox.Text;
            DateTime birthDate;
            if (DateTime.TryParseExact(birthDateText, "yyyy/MM/dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out birthDate))
            {
                user.DateOfBirth = DateOfBirthBox.Text;
                label1.Visible = false;
            }
            else
            {
                label1.Text = "لطفا تاریخ تولد را به صورت سال-ماه-روز وارد کنید.";
                label1.Visible = true;

            }
        }

        private void PhoneNumberBox_TextChanged(object sender, EventArgs e)
        {
            if (PhoneNumberBox.Text.Length == 11 && Int64.Parse(PhoneNumberBox.Text) == 0)
            {
                PhoneNumberBox.Text = PhoneNumberBox.Text.Substring(0, 11);
            }

            user.PhoneNumber = PhoneNumberBox.Text;

        }

        private void FirtsNameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar > 199 || e.KeyChar < 237)
       && (e.KeyChar < 1574 || e.KeyChar > 1594 && e.KeyChar < 1601 || e.KeyChar > 1608)
       && e.KeyChar != 1662 && e.KeyChar != 1668 && e.KeyChar != 1670 && e.KeyChar != 1705
       && e.KeyChar != 1711
       && e.KeyChar != 1740 && e.KeyChar != 8 && e.KeyChar != 32)
            {
                e.Handled = true;
            }
        }

        private void LastNameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar > 199 || e.KeyChar < 237)
        && (e.KeyChar < 1574 || e.KeyChar > 1594 && e.KeyChar < 1601 || e.KeyChar > 1608)
        && e.KeyChar != 1662 && e.KeyChar != 1668 && e.KeyChar != 1670 && e.KeyChar != 1705
        && e.KeyChar != 1711
        && e.KeyChar != 1740 && e.KeyChar != 8 && e.KeyChar != 32)
            {
                e.Handled = true;
            }
        }

        private void NationalIdBox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void NationalIdBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void Register_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}

