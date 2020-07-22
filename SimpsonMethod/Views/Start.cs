using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpsonMethod.Views
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void toCountingWindowButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CountingWindow cW = new CountingWindow();
            cW.Show();
        }

        private void toAboutAuthorsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AboutProject aA = new AboutProject();
            aA.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Start_Load(object sender, EventArgs e)
        {

        }
    }
}
