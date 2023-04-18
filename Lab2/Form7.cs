using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; 
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Lab2
{
    public partial class Form7 : Form
    {

        public Form7()
        {
            InitializeComponent();
            InitControls();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            InitTree();
        }
        private void InitTree()
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            TreeNode node = null;
            foreach (DriveInfo drive in drives)
            {
                node = new TreeNode(drive.Name);
                treeFolder.Nodes.Add(node);
                node.Nodes.Add("Temp");
            }
        }

        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            TreeNode node = e.Node;
            node.Nodes.Clear();
            node.ImageIndex = 1;
            try
            {
                string[] files = Directory.GetFiles(node.FullPath);
                foreach (string dir in Directory.GetDirectories(node.FullPath))
                {
                    TreeNode n = node.Nodes.Add(Path.GetFileName(dir));
                    n.Nodes.Add("Temp");
                }
                foreach (string file in files)
                {
                    if (IsImageFile(file))
                    {
                        TreeNode imageNode = node.Nodes.Add(Path.GetFileName(file));
                        imageNode.ImageKey = "image";
                        imageNode.SelectedImageKey = "image";
                    }
                }
            }
            catch { }
        }

        private void treeView1_BeforeCollapse(object sender, TreeViewCancelEventArgs e)
        {
            e.Node.ImageIndex = 0;
        }

        private void InitControls()
        {
            picView = new PictureBox();
            picView.SizeMode = PictureBoxSizeMode.Zoom;
            picView.Dock = DockStyle.Fill;
            this.Controls.Add(picView);
        }
        private bool IsImageFile(string filePath)
        {
            string extension = Path.GetExtension(filePath).ToLower();
            return extension == ".jpg" || extension == ".jpeg" || extension == ".png" || extension == ".bmp" || extension == ".gif";
        }


        private void treeFolder_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                picView.Image = null;
                string[] arrFiles = Directory.GetFiles(e.Node.FullPath);
                foreach (string file in arrFiles)
                {
                    if (file.ToLower().EndsWith(".jpg") ||
                        file.ToLower().EndsWith(".gif") ||
                        file.ToLower().EndsWith(".png") ||
                        file.ToLower().EndsWith(".bmp") ||
                        file.ToLower().EndsWith(".jpeg"))
                    {
                        picView.Image = Image.FromFile(file);
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void treeFolder_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            try
            {
                string fullPath = e.Node.FullPath;
                if (File.Exists(fullPath) && IsImageFile(fullPath))
                {
                    picView.Image = Image.FromFile(fullPath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    } 
}
