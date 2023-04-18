namespace Lab2
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bt_read = new System.Windows.Forms.Button();
            this.tb_hienthi = new System.Windows.Forms.TextBox();
            this.filename = new System.Windows.Forms.TextBox();
            this.url = new System.Windows.Forms.TextBox();
            this.linecount = new System.Windows.Forms.TextBox();
            this.wordscount = new System.Windows.Forms.TextBox();
            this.crtcount = new System.Windows.Forms.TextBox();
            this.size = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_read
            // 
            this.bt_read.AutoSize = true;
            this.bt_read.BackColor = System.Drawing.SystemColors.Info;
            this.bt_read.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_read.Location = new System.Drawing.Point(12, 12);
            this.bt_read.Name = "bt_read";
            this.bt_read.Size = new System.Drawing.Size(313, 33);
            this.bt_read.TabIndex = 0;
            this.bt_read.Text = "Read From File";
            this.bt_read.UseVisualStyleBackColor = false;
            this.bt_read.Click += new System.EventHandler(this.bt_read_Click);
            // 
            // tb_hienthi
            // 
            this.tb_hienthi.BackColor = System.Drawing.SystemColors.InfoText;
            this.tb_hienthi.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_hienthi.ForeColor = System.Drawing.SystemColors.Window;
            this.tb_hienthi.Location = new System.Drawing.Point(345, 12);
            this.tb_hienthi.Multiline = true;
            this.tb_hienthi.Name = "tb_hienthi";
            this.tb_hienthi.Size = new System.Drawing.Size(443, 500);
            this.tb_hienthi.TabIndex = 1;
            // 
            // filename
            // 
            this.filename.Location = new System.Drawing.Point(149, 89);
            this.filename.Multiline = true;
            this.filename.Name = "filename";
            this.filename.Size = new System.Drawing.Size(185, 31);
            this.filename.TabIndex = 2;
            // 
            // url
            // 
            this.url.Location = new System.Drawing.Point(149, 216);
            this.url.Multiline = true;
            this.url.Name = "url";
            this.url.Size = new System.Drawing.Size(185, 31);
            this.url.TabIndex = 3;
            // 
            // linecount
            // 
            this.linecount.Location = new System.Drawing.Point(149, 281);
            this.linecount.Multiline = true;
            this.linecount.Name = "linecount";
            this.linecount.Size = new System.Drawing.Size(185, 31);
            this.linecount.TabIndex = 4;
            // 
            // wordscount
            // 
            this.wordscount.Location = new System.Drawing.Point(149, 345);
            this.wordscount.Multiline = true;
            this.wordscount.Name = "wordscount";
            this.wordscount.Size = new System.Drawing.Size(185, 31);
            this.wordscount.TabIndex = 5;
            // 
            // crtcount
            // 
            this.crtcount.Location = new System.Drawing.Point(149, 407);
            this.crtcount.Multiline = true;
            this.crtcount.Name = "crtcount";
            this.crtcount.Size = new System.Drawing.Size(185, 38);
            this.crtcount.TabIndex = 6;
            // 
            // size
            // 
            this.size.Location = new System.Drawing.Point(149, 152);
            this.size.Multiline = true;
            this.size.Name = "size";
            this.size.Size = new System.Drawing.Size(185, 31);
            this.size.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(8, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "File name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(8, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(8, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "URL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(8, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Line Count";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(8, 356);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Words Count";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label6.Location = new System.Drawing.Point(8, 419);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "Characters Count";
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.SystemColors.Info;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 479);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(313, 33);
            this.button1.TabIndex = 14;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 524);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.size);
            this.Controls.Add(this.crtcount);
            this.Controls.Add(this.wordscount);
            this.Controls.Add(this.linecount);
            this.Controls.Add(this.url);
            this.Controls.Add(this.filename);
            this.Controls.Add(this.tb_hienthi);
            this.Controls.Add(this.bt_read);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_read;
        private System.Windows.Forms.TextBox tb_hienthi;
        private System.Windows.Forms.TextBox filename;
        private System.Windows.Forms.TextBox url;
        private System.Windows.Forms.TextBox linecount;
        private System.Windows.Forms.TextBox wordscount;
        private System.Windows.Forms.TextBox crtcount;
        private System.Windows.Forms.TextBox size;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
    }
}