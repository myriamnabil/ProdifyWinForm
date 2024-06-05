using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class Form24 : Form
    {
        public Form24()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form25 form25 = new Form25();
            form25.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form26 form26 = new Form26();
            form26.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form27 form27 = new Form27();
            form27.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form28 form28 = new Form28();
            form28.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form30 form30 = new Form30();
            form30.Show();
            this.Hide();
        }
    }
}
