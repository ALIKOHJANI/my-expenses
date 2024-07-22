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
        AddGroupingService AddGroupingClass = new AddGroupingService();
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
            this.Close();
        }

        private void DescriptionBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void NameGroupingBox_KeyPress(object sender, KeyPressEventArgs e)
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

