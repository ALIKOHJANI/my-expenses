using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace myExpenses
{
    public partial class GeneralReport : Form
    {
        public GeneralReport()
        {
            InitializeComponent();
        }

        private void GeneralReport_Load(object sender, EventArgs e)
        {

            foreach (var item in Data.expenses)
            {

                PersianCalendar DatePc = new PersianCalendar();
                DateTime dateTime = item.Date;
                string PersianDate = string.Format("{0}/{1}/{2}", DatePc.GetYear(dateTime), DatePc.GetMonth(dateTime), DatePc.GetDayOfMonth(dateTime));
                listGeneralReport.Rows.Add(item.Amount, item.cards, item.Grouping, PersianDate);

            }

            int sum = Data.expenses.Sum(c => c.Amount);
            SumOfExpensesLabel.Text = sum.ToString();

            SumOfExpensesTEXT.Text = PersianNumberToString.GET_Number_To_PersianString(SumOfExpensesLabel.Text) + " " + "تومان";
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            reporting reporting = new reporting();
            reporting.Show();
            this.Close();
        }
    }
}
