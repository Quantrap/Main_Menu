using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UP
{
    public partial class FormAuthorization : Form
    {
        public FormAuthorization()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            
            Form form = new FormMainMenu();
            form.Show();
            this.Hide();

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            textBoxEmail.Text = "";
            textBoxPassword.Text = "";
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
