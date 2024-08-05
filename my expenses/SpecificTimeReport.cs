using System.Globalization;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace myExpenses
{
    public partial class SpecificTimeReport : Form
    {
        public SpecificTimeReport()
        {
            InitializeComponent();
        }

        private void SpecificTimeReport_Load(object sender, EventArgs e)
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

        private void reportingButton_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            PersianCalendar pc = new PersianCalendar();
            var startDateTimeSplit = StartDateTextBox.Text.Split('/');
            var endDateTimeSplit = EndDateTextBox.Text.Split('/');

            DateTime StartDateTimeSplit = new DateTime(Convert.ToInt32(startDateTimeSplit[0]), Convert.ToInt32(startDateTimeSplit[1]), Convert.ToInt32(startDateTimeSplit[2]), pc);
            DateTime EndDateTimeSplit = new DateTime(Convert.ToInt32(endDateTimeSplit[0]), Convert.ToInt32(endDateTimeSplit[1]), Convert.ToInt32(endDateTimeSplit[2]), pc);
            foreach (var item in Data.expenses)
            {
                string StartDate = StartDateTextBox.Text;
                DateTime birthDate;
                if (DateTime.TryParseExact(StartDate, "yyyy/MM/dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out birthDate))
                {


                }
                else
                {
                    MessageBox.Show("تاریخ تولد را درست وارد کنید");
                    Visible = false;


                }

                if (isValid)
                {
                    if (item.Date >= StartDateTimeSplit && item.Date <= EndDateTimeSplit)
                    {
                        if (item.cards == CardBox.Text )
                        {
                            PersianCalendar DatePc = new PersianCalendar();
                            DateTime dateTime = item.Date;
                            string PersianDate = string.Format("{0}/{1}/{2}", DatePc.GetYear(dateTime), DatePc.GetMonth(dateTime), DatePc.GetDayOfMonth(dateTime));
                            listMonthlyReport.Rows.Add(item.Amount, item.cards, item.Grouping, PersianDate);
                            Int64 sum = Data.expenses.Sum(c => c.Amount);
                            SumOfExpensesLabel.Text = sum.ToString();
                            SumOfExpensesTEXT.Text = PersianNumberToString.GET_Number_To_PersianString(SumOfExpensesLabel.Text) + " " + "تومان";
                        }
                        if(item.Grouping == GroupingBox.Text)
                        {
                            PersianCalendar DatePc = new PersianCalendar();
                            DateTime dateTime = item.Date;
                            string PersianDate = string.Format("{0}/{1}/{2}", DatePc.GetYear(dateTime), DatePc.GetMonth(dateTime), DatePc.GetDayOfMonth(dateTime));
                            listMonthlyReport.Rows.Add(item.Amount, item.cards, item.Grouping, PersianDate);
                            Int64 sum = Data.expenses.Sum(c => c.Amount);
                            SumOfExpensesLabel.Text = sum.ToString();
                            SumOfExpensesTEXT.Text = PersianNumberToString.GET_Number_To_PersianString(SumOfExpensesLabel.Text) + " " + "تومان";

                        }
                        if (GroupingBox.Text == null && CardBox.Text == null)
                        {
                            PersianCalendar DatePc = new PersianCalendar();
                            DateTime dateTime = item.Date;
                            string PersianDate = string.Format("{0}/{1}/{2}", DatePc.GetYear(dateTime), DatePc.GetMonth(dateTime), DatePc.GetDayOfMonth(dateTime));
                            listMonthlyReport.Rows.Add(item.Amount, item.cards, item.Grouping, PersianDate);
                            Int64 sum = Data.expenses.Sum(c => c.Amount);
                            SumOfExpensesLabel.Text = sum.ToString();
                            SumOfExpensesTEXT.Text = PersianNumberToString.GET_Number_To_PersianString(SumOfExpensesLabel.Text) + " " + "تومان";

                        }
                    }
                }
            }

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            reporting reporting = new reporting();
            reporting.Show();
            this.Close();
        }

        private void SpecificTimeReport_FormClosed(object sender, FormClosedEventArgs e)
        {


        }

        private void SpecificTimeReport_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
    }
}
