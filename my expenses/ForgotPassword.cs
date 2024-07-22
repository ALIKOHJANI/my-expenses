using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myExpenses
{

    public partial class ForgotPassword : Form
    {
        User user = new User("علی", "کوهجانی", "Aa13801380", "0481110208");
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void SendSMSbutton_Click(object sender, EventArgs e)
        {
            ExpnsesServis expnsesServis = new ExpnsesServis();
            string NationalId = SendSMSBox.Text;
            bool isValid = false;
            string NewPassword = "";
            foreach (User item in Data.Users)
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
                        if (item.NationalId == NationalId)
                        {

                            NewPassword = expnsesServis.GenerateNewPassword();
                            NationalIdBox.Text = NewPassword;
                            item.Password = NewPassword;

                        }
                        else
                        {
                            MessageBox.Show("کد ملی نامعتبر است");
                        }

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


            }


        }
        private void ComingBackButton_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.Show();
            this.Close();
        }

        private void SendSMSBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')

            {
                e.Handled = true;
            }

        }

    }
}

