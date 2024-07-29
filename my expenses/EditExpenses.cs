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
    public partial class EditExpenses : Form
    {
        public EditExpenses(string EditExpenses )
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            mainPage.Show();
            this.Close();
        }
    }
}
