using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 myform = new Form2();
            myform.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 myform = new Form3();
            myform.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 myform = new Form4();
            myform.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 myform = new Form5();
            myform.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form6 myform = new Form6();
            myform.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form7 myform = new Form7();
            myform.ShowDialog();
        }
    }
}
