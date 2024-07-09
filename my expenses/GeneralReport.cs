using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace my_expenses
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
                listGeneralReport.Items.Add(item.Amount + ":شماره کارت" + item.cards);

            }

            int sum = Data.expenses.Sum(c => c.Amount);
            SumOfExpensesLabel.Text = sum.ToString();

            SumOfExpensesTEXT.Text = Persian_Number_To_String.GET_Number_To_PersianString(SumOfExpensesLabel.Text) + " " + "تومان";
        }
    }
}
