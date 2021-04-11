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
    public partial class FormRegisterAsRunner : Form
    {
        public FormRegisterAsRunner()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Form form = new FormMainMenu();
            form.Show();
            this.Hide();
        }

        private void FormRegisterAsRunner_Load(object sender, EventArgs e)
        {

        }

        private void buttonRunner_Click(object sender, EventArgs e)
        {
            Form form = new FormAuthorization();
            form.Show();
            this.Hide();
        }

        private void buttonNewRunner_Click(object sender, EventArgs e)
        {
            Form form = new FormNewRunner();
            form.Show();
            this.Hide();
        }
    }
}
