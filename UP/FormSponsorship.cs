using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace UP
{
    public partial class FormSponsorship : Form
    {
        public FormSponsorship()
        {
            InitializeComponent();
            labelPrice.Text = "$10";
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Form form = new FormMainMenu();
            form.Show();
            this.Hide();
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            labelPrice.Text= "$"+Convert.ToString(Convert.ToInt32(labelPrice.Text.Substring(1, labelPrice.Text.Length - 1))+10);
            textBoxPrice.Text = labelPrice.Text.Substring(1, labelPrice.Text.Length - 1);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form form = new FormMainMenu();
            form.Show();
            this.Hide();
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            if ((Convert.ToInt32(labelPrice.Text.Substring(1, labelPrice.Text.Length - 1)) - 10) >= 20)
            {
                labelPrice.Text = "$" + Convert.ToString(Convert.ToInt32(labelPrice.Text.Substring(1, labelPrice.Text.Length - 1)) - 10);
                textBoxPrice.Text = labelPrice.Text.Substring(1, labelPrice.Text.Length - 1);
            }
            else
            {
                labelPrice.Text = "$10";
                textBoxPrice.Text = "10";
            }
        }

        private void textBoxPrice_Leave(object sender, EventArgs e)
        {
           
        }
        private void textBoxPrice_TextChanged(object sender, EventArgs e)
        {
            int b = 0;
            if (Int32.TryParse(textBoxPrice.Text, out b))
            {
                if (Convert.ToInt32(textBoxPrice.Text) > 0)
                {
                    labelPrice.Text = "$" + textBoxPrice.Text;

                }
            }
        }
    }
    
}
