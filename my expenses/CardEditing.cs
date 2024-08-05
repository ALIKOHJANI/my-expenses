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
    public partial class CardEditing : Form
    {
        public CardEditing()
        {
            InitializeComponent();
        }

        public void backButton_Click(object sender, EventArgs e)
        {
            Cards cards = new Cards();
            cards.Show();
            this.Close();
        }

        public void Delete_Click(object sender, EventArgs e)
        {
            if (Data.Addcards.Count == 0)
            {
                MessageBox.Show("موردي براي ويرايش وجود ندارد", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            for (int i = 1; i <= Data.Addcards.Count;)
            {
                foreach (var item in Data.Addcards)
                {
                    if (item.cardNumber == CardNumberBox.Text)
                    {
                        if (item.cardNumber == CardNumberBox.Text)
                        {
                            Data.Addcards.Remove(item);
                            MessageBox.Show("سطر با موفقيت حذف گرديد", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        Cards cards = new Cards();
                        cards.Show();
                        this.Close();
                        break;
                    }
                    i++;
                }

            }
        }


        private void Entrybutton_Click(object sender, EventArgs e)
        {

        }
    }
}
