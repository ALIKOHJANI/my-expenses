using myExpenses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace my_expenses
{
    public partial class CardEditing : Form
    {
        public CardEditing()
        {
            InitializeComponent();
        }

        public void backButton_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            mainPage.Show();
            this.Close();
        }

        public void Delete_Click(object sender, EventArgs e)
        {
            foreach (var item in Data.Addcards)
            {
                if (item.cardNumber == CardNumberBox.Text)
                {
                    Data.Addcards.Remove(item);
                }
            }
        }
    }
}
