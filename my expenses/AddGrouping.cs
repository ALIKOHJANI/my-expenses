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
    public partial class AddGrouping : Form
    {
        public AddGrouping()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Grouping grouping = new Grouping();
            grouping.Show();
            this.Close();
        }
        AddGroupingClass AddGroupingClass = new AddGroupingClass();
        private void NameGroupingBox_TextChanged(object sender, EventArgs e)
        {
            AddGroupingClass.Name = NameGroupingBox.Text;

        }

        private void DescriptionBox_TextChanged(object sender, EventArgs e)
        {
            AddGroupingClass.Description = DescriptionBox.Text;
        }

        private void Enterbutton_Click(object sender, EventArgs e)
        {
            Data.addGroupings.Add(AddGroupingClass);
            Grouping grouping = new Grouping();
            grouping.Show();
        }
    }
}
