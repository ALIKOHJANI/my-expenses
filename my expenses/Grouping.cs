﻿using my_expenses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace myExpenses
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
            this.Close();
        }

        private void Grouping_Load(object sender, EventArgs e)
        {
            bool isValid = true;
            foreach (var item in Data.addGroupings)
            {
                isValid = false;
                GroupingListBox.Rows.Add(item.Name);
                GroupingBox.Items.Add(item.Name);
            }
            if (isValid)
            {

                ErrorLabel1.Text = "!دسته بندی  ندارید";
                ErrorLabel2.Text = "میتوانید دسته  بندی  خود   را  اضافه کنید";

            }
            else
            {
                ErrorLabel1.Text = "";
                ErrorLabel2.Text = "";


            }

        }

        private void GroupingBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            GroupingBox.SelectedIndex = GroupingBox.FindString(GroupingBox.Text);
            EditCategories editCategories = new EditCategories(GroupingBox.Text);
            editCategories.ShowDialog();
        }

        private void Grouping_FormClosed(object sender, FormClosedEventArgs e)
        {


        }
    }
}
