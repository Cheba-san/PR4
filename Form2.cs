using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace work
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 Win = new Form4();
            Win.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 Win = new Form3();
            Win.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 Win = new Form5();
            Win.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 Win = new Form6();
            Win.ShowDialog();
        }
    }
}
