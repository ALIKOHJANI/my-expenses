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
    public partial class Addcard : Form
    {
        public Addcard()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            mainPage.Show();
            this.Close();

        }
        AddcardClass addcardClass = new AddcardClass();
        private void bankComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            addcardClass.bank = bankComboBox.Text;
        }

        private void CardNumberBox_TextChanged(object sender, EventArgs e)
        {
            addcardClass.cardNumber = CardNumberBox.Text;
        }

        private void CardNameBox_TextChanged(object sender, EventArgs e)
        {
            addcardClass.name = CardNameBox.Text;
        }

        private void Entrybutton_Click(object sender, EventArgs e)
        {
            Data.Addcards.Add(addcardClass);
            Cards cards = new Cards();
            cards.Show();
            this.Close();
        }

        private void CardNameBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void CardNumberBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
    }
}

