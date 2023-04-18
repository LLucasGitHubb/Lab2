using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private string _inputFilePath;

        private async void read_Click(object sender, EventArgs e)
        {
            try
            {
                var openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Txt Files| *.txt";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    _inputFilePath = Path.GetDirectoryName(openFileDialog.FileName);
                    using (var streamReader = new StreamReader(openFileDialog.FileName))
                    {
                        tb_expression.Text = streamReader.ReadToEndAsync().Result;
                    }
                    MessageBox.Show($"Đọc file {openFileDialog.FileName} thành công");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void calculate_Click(object sender, EventArgs e)
        {
            try
            {
                tb_result.Text = "";
                foreach (var expression in tb_expression.Lines)
                {
                    var result = new DataTable().Compute(expression, null);
                    tb_result.Text += $"{expression} = {result:0.##}{Environment.NewLine}";
                }
                var outputPath = Path.Combine(Path.GetDirectoryName(_inputFilePath), "output3.txt");
                File.WriteAllText(outputPath, tb_result.Text);
                MessageBox.Show($"Ghi thành công file tại {outputPath}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
