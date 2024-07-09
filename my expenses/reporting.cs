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
    public partial class reporting : Form
    {
        public reporting()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            mainPage.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ReportTypeBox.Text== "گزارش کلی")
            {
                MonthlyReport monthlyReport = new MonthlyReport();
                monthlyReport.Show();
                this.Close();
            }
            if (ReportTypeBox.Text == "گزارش بازه دلخواه")
            {
                SpecificTimeReport specificTimeReport = new SpecificTimeReport();
                specificTimeReport.Show();
                this.Close();
            }
        }
    }
}
