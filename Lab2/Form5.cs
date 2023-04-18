using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;

namespace Lab2
{
    public partial class Form5 : Form
    {
        [Serializable]
        internal class SinhVien
        {
            public string HoVaTen { get; set; }
            public int MSSV { get; set; }
            public string SDT { get; set; }
            public double Diem1 { get; set; }
            public double Diem2 { get; set; }
            public double Diem3 { get; set; }
            public double DTB { get; set; }

            public SinhVien() { }

        }
        private List<SinhVien> _sinhVien;

        private int _index = 0;
        public Form5()
        {
            InitializeComponent();
            _sinhVien = new List<SinhVien>();
        }
       

        private void bt_add_Click(object sender, EventArgs e)
        {

        }

        private void read_Click(object sender, EventArgs e)
        {
            try
            {
                var openFileDialog = new OpenFileDialog
                {
                    Filter = "Txt Files| *.txt"
                };
                string fileContent;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    _sinhVien.Clear();
                    using (var streamReader = new StreamReader(openFileDialog.FileName))
                    {
                        while (streamReader.Peek() >= 0)
                        {
                            var sinhVien = new SinhVien();

                            sinhVien.HoVaTen = streamReader.ReadLine();
                            sinhVien.MSSV = int.Parse(streamReader.ReadLine());
                            sinhVien.SDT = streamReader.ReadLine();
                            sinhVien.Diem1 = double.Parse(streamReader.ReadLine());
                            sinhVien.Diem2 = double.Parse(streamReader.ReadLine());
                            sinhVien.Diem3 = double.Parse(streamReader.ReadLine());
                            sinhVien.DTB = (sinhVien.Diem1 + sinhVien.Diem2 + sinhVien.Diem3) / 3;
                            _sinhVien.Add(sinhVien);
                            _ = streamReader.ReadLine();
                        }
                    }
                    MessageBox.Show($"Read file from {openFileDialog.FileName} success");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void write_Click(object sender, EventArgs e)
        {
            if (_sinhVien.Count == 0)
            {
                MessageBox.Show("Please input student info", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                var saveFileDialog = new SaveFileDialog
                {
                    Filter = "Dat file|*.dat",
                    FileName = "output4.dat"
                };
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var outputPath = saveFileDialog.FileName;
                    using (var fileStream = File.Open(outputPath, FileMode.Create))
                    {
                        var binaryFormatter = new BinaryFormatter();
#pragma warning disable SYSLIB0011
                        binaryFormatter.Serialize(fileStream, _sinhVien);
#pragma warning restore SYSLIB0011
                    }
                    MessageBox.Show($"Ghi thành công file tại {outputPath}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
