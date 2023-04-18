using System;
using System.IO;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void bt_read_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.FileName = Path.GetFileName(ofd.FileName);
            ofd.ShowDialog();
            if (File.Exists(ofd.FileName))
            {
                using (StreamReader sr = new StreamReader(ofd.FileName)) { tb_hienthi.Text = sr.ReadToEnd(); }
            }
            Name = ofd.SafeFileName.ToString();
            filename.Text = Name;
            long fileSizeInBytes = new FileInfo(ofd.FileName).Length;
            string fileSizeString = string.Empty;
            fileSizeString = fileSizeInBytes.ToString() + " bytes";
            size.Text = fileSizeString;
            string fileUrl = ofd.FileName;
            url.Text = fileUrl;
            int lineCount = File.ReadAllText(ofd.FileName).Split('\n').Length;
            linecount.Text = lineCount.ToString();
            int wordCount = File.ReadAllText(ofd.FileName).Split(new char[] { ' ', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries).Length;
            wordscount.Text = wordCount.ToString();
            int charCount = File.ReadAllText(ofd.FileName).Length;
            crtcount.Text = crtcount.ToString();
        }
    }
}
