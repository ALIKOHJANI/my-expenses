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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace myExpenses
{
    public partial class MonthlyReport : Form
    {
        public MonthlyReport()
        {
            InitializeComponent();
        }

        private void MonthlyReport_Load(object sender, EventArgs e)
        {

            foreach (var item in Data.Addcards)
            {
                CardBox.Items.Add(item.cardNumber);
            }
            foreach (var item in Data.addGroupings)
            {
                GroupingBox.Items.Add(item.Name);
            }

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            reporting reporting = new reporting();
            reporting.Show();
            this.Close();
        }

        private void MonthlyReport_FormClosed(object sender, FormClosedEventArgs e)
        {


        }

        private void reportingButton_Click(object sender, EventArgs e)
        {
            listMonthlyReport.Rows.Clear();
            if (String.IsNullOrEmpty(ChooseTheMonth.Text))
            {
                MessageBox.Show("ماه را انتخواب نمایید");
            }
            else
            {

                foreach (var item in Data.expenses)
                {

                    (DateTime start, DateTime end) = ConvertDateTime.GetGregorianDates(ChooseTheMonth.Text);

                    if (item.Date >= start && item.Date <= end)
                    {
                        if (item.cards == CardBox.Text)
                        {
                            Int64 sum = Data.expenses.Sum(c => c.Amount);
                            SumOfExpensesLabel.Text = sum.ToString();
                            SumOfExpensesTEXT.Text = PersianNumberToString.GET_Number_To_PersianString(SumOfExpensesLabel.Text) + " " + "تومان";
                            PersianCalendar pc = new PersianCalendar();
                            DateTime dateTime = item.Date;
                            string PersianDate = string.Format("{0}/{1}/{2}", pc.GetYear(dateTime), pc.GetMonth(dateTime), pc.GetDayOfMonth(dateTime));
                            listMonthlyReport.Rows.Add(item.Amount, item.cards, item.Grouping, PersianDate);
                        }
                        if (item.Grouping == GroupingBox.Text)
                        {

                            Int64 sum = Data.expenses.Sum(c => c.Amount);
                            SumOfExpensesLabel.Text = sum.ToString();
                            SumOfExpensesTEXT.Text = PersianNumberToString.GET_Number_To_PersianString(SumOfExpensesLabel.Text) + " " + "تومان";
                            PersianCalendar pc = new PersianCalendar();
                            DateTime dateTime = item.Date;
                            string PersianDate = string.Format("{0}/{1}/{2}", pc.GetYear(dateTime), pc.GetMonth(dateTime), pc.GetDayOfMonth(dateTime));
                            listMonthlyReport.Rows.Add(item.Amount, item.cards, item.Grouping, PersianDate);
                        }
                        if (GroupingBox.Text == null && CardBox.Text == null)
                        {

                            Int64 sum = Data.expenses.Sum(c => c.Amount);
                            SumOfExpensesLabel.Text = sum.ToString();
                            SumOfExpensesTEXT.Text = PersianNumberToString.GET_Number_To_PersianString(SumOfExpensesLabel.Text) + " " + "تومان";
                            PersianCalendar pc = new PersianCalendar();
                            DateTime dateTime = item.Date;
                            string PersianDate = string.Format("{0}/{1}/{2}", pc.GetYear(dateTime), pc.GetMonth(dateTime), pc.GetDayOfMonth(dateTime));
                            listMonthlyReport.Rows.Add(item.Amount, item.cards, item.Grouping, PersianDate);

                        }
                    }
                }
            }
        }

        private void CardBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')

            {
                e.Handled = true;
            }
        }

        private void GroupingBox_KeyPress(object sender, KeyPressEventArgs e)
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
    }


}


