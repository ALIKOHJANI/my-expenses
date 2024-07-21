using System.Globalization;
using System.Windows.Forms;

namespace my_expenses
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

            PersianCalendar pc = new PersianCalendar();
            var startDateTimeSplit = StartDateTextBox.Text.Split('/');
            var endDateTimeSplit = EndDateTextBox.Text.Split('/');

            DateTime StartDateTimeSplit = new DateTime(Convert.ToInt32(startDateTimeSplit[0]), Convert.ToInt32(startDateTimeSplit[1]), Convert.ToInt32(startDateTimeSplit[2]), pc);
            DateTime EndDateTimeSplit = new DateTime(Convert.ToInt32(endDateTimeSplit[0]), Convert.ToInt32(endDateTimeSplit[1]), Convert.ToInt32(endDateTimeSplit[2]), pc);
            foreach (var item in Data.expenses)
            {
                if (item.Date >= StartDateTimeSplit && item.Date <= EndDateTimeSplit)
                {
                    listMonthlyReport.Rows.Add(item.Amount, item.cards, item.Grouping, item.Date);
                    int sum = Data.expenses.Sum(c => c.Amount);
                    SumOfExpensesLabel.Text = sum.ToString();
                    SumOfExpensesTEXT.Text = Persian_Number_To_String.GET_Number_To_PersianString(SumOfExpensesLabel.Text) + " " + "تومان";

                }
            }

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            reporting reporting = new reporting();
            reporting.Show();
            this.Close();
        }
    }
}
