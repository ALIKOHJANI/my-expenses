﻿namespace my_expenses
{
    public partial class SpecificTimeReport : Form
    {
        public SpecificTimeReport()
        {
            InitializeComponent();
        }

        private void SpecificTimeReport_Load(object sender, EventArgs e)
        {
            InWords.Text = Persian_Number_To_String.GET_Number_To_PersianString(number.Text) + "" + "تومان";
            foreach (var item in Data.Addcards)
            {
                CardBox.Items.Add(item.cardNumber);
            }
            foreach (var item in Data.addGroupings)
            {
                GroupingBox.Items.Add(item.Name);
            }
        }

    }
}
