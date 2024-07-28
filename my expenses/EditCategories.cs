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

    public partial class EditCategories : Form
    {
        AddGroupingService groupingService = new AddGroupingService();
        public EditCategories(string GroupingBox)
        {
            InitializeComponent();
            NameGroupingBox.Text = GroupingBox;
        }

        public void BackButton_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            mainPage.Show();
            this.Close();
        }


        public void Enterbutton_Click(object sender, EventArgs e)
        {
            foreach (AddGroupingService Item in Data.addGroupings)
            {
               Data.addGroupings.Add(groupingService);
           
            }


        }

        private void EditCategories_Load(object sender, EventArgs e)
        {
            foreach (AddGroupingService Item in Data.addGroupings)
            {
                if (Item.Name == NameGroupingBox.Text)
                {
                    DescriptionBox.Text = Item.Description;
                }

            }
        }

        private void NameGroupingBox_TextChanged(object sender, EventArgs e)
        {
            groupingService.Name = NameGroupingBox.Text;
        }

        private void DescriptionBox_TextChanged(object sender, EventArgs e)
        {
            groupingService.Description = DescriptionBox.Text; 
        }
    }
}
