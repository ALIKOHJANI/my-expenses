using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace my_expenses
{
    public partial class AddingExpenses : Form
    {
        public AddingExpenses()
        {
            InitializeComponent();
        }
        Epenses epenses = new Epenses();
        private void BackButton_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            mainPage.Show();
            this.Close();
        }

        private void AmountBox_TextChanged(object sender, EventArgs e)
        {
            epenses.Amount = Convert.ToInt32(AmountBox.Text);

        }

        private void GroupingBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            epenses.Grouping = GroupingBox.Text;
            GroupingBox.SelectedIndex = GroupingBox.FindString(GroupingBox.Text);
        }

        private void DescriptionBox_TextChanged(object sender, EventArgs e)
        {
            epenses.Description = DescriptionBox.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {


            Data.expenses.Add(epenses);

            MainPage mainPage = new MainPage();
            mainPage.Show();
            this.Close();
            
        }

        private void AddingExpenses_Load(object sender, EventArgs e)
        {
            foreach (var item in Data.Addcards)
            {
                CardNumberBox.Items.Add(item.cardNumber);
            }
            foreach (var item in Data.addGroupings)
            {
                GroupingBox.Items.Add(item.Name);
            }
            epenses.cards = CardNumberBox.Text;
        }

        private void AmountBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')

            {
                e.Handled = true;
            }
        }
    }
}
