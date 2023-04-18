using System;
using System.IO;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Readfiles_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.FileName = Path.GetFileName(ofd.FileName);
            ofd.ShowDialog();
            if (File.Exists(ofd.FileName))
            {
                using (StreamReader sr = new StreamReader(ofd.FileName)) { textBox1.Text = sr.ReadToEnd(); }
            }
        }

        private void Writefiles_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.ShowDialog();
            FileStream fs = new FileStream(sfd.FileName, FileMode.OpenOrCreate);
            if (File.Exists(sfd.FileName))
            {
                using (StreamWriter sr = new StreamWriter(fs))
                    sr.WriteLine(textBox1.Text.ToUpper());
            }
        }
    }
}
