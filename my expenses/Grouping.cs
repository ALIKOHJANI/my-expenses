using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace my_expenses
{
    public partial class Grouping : Form
    {
        public Grouping()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            mainPage.Show();
            this.Hide();
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            AddGrouping addGrouping = new AddGrouping();
            addGrouping.Show();
        }

        private void Grouping_Load(object sender, EventArgs e)
        {
            foreach (var item in Data.addGroupings)
            {
                GroupingListBox.Items.Add(item.Name);
                GroupingBox.Items.Add(item.Name);
            }

        }

        private void GroupingBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            GroupingBox.SelectedIndex = GroupingBox.FindString(GroupingBox.Text);
        }
    }
}
