using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myExpenses
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
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ReportTypeBox.Text == "گزارش کلی")
            {
                GeneralReport generalReport = new GeneralReport();
                generalReport.Show();
                this.Close();
            }
            if (ReportTypeBox.Text == "گزارش بازه دلخواه")
            {
                SpecificTimeReport specificTimeReport = new SpecificTimeReport();
                specificTimeReport.Show();
                this.Close();
            }
            if (ReportTypeBox.Text == "گزارش ماهانه")
            {
                MonthlyReport monthlyReport = new MonthlyReport();
                monthlyReport.Show();
                this.Close();

            }

        }

        private void reporting_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
