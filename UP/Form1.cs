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
    public partial class FormMainMenu : Form
    {
        TimeSpan d = new TimeSpan();
        DateTime date = new DateTime(2019, 1, 1);
        public FormMainMenu()
        {
            InitializeComponent();
            this.Resizable = false;
            this.MaximizeBox = false;
            timer1.Start();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Form form = new FormAuthorization();
            form.Show();
            this.Hide();
        }

        private void buttonRunner_Click(object sender, EventArgs e)
        {
            Form form = new FormRegisterAsRunner();
            form.Show();
            this.Hide();
        }

        private void buttonSponsor_Click(object sender, EventArgs e)
        {
            Form form = new FormSponsorship();
            form.Show();
            this.Hide();
        }

        private void buttonEventInfo_Click(object sender, EventArgs e)
        {
            Form form = new FormAboutEvent();
            form.Show();
            this.Hide();
        }
    }
}
