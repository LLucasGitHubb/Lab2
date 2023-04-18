namespace Lab2
{
    partial class Form2
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
            this.Readfiles = new System.Windows.Forms.Button();
            this.Writefiles = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Readfiles
            // 
            this.Readfiles.AutoSize = true;
            this.Readfiles.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Readfiles.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Readfiles.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Readfiles.Location = new System.Drawing.Point(56, 50);
            this.Readfiles.Name = "Readfiles";
            this.Readfiles.Size = new System.Drawing.Size(216, 67);
            this.Readfiles.TabIndex = 0;
            this.Readfiles.Text = "ĐỌC FILES";
            this.Readfiles.UseVisualStyleBackColor = false;
            this.Readfiles.Click += new System.EventHandler(this.Readfiles_Click);
            // 
            // Writefiles
            // 
            this.Writefiles.AutoSize = true;
            this.Writefiles.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Writefiles.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Writefiles.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Writefiles.Location = new System.Drawing.Point(56, 203);
            this.Writefiles.Name = "Writefiles";
            this.Writefiles.Size = new System.Drawing.Size(216, 67);
            this.Writefiles.TabIndex = 1;
            this.Writefiles.Text = "GHI FILES";
            this.Writefiles.UseVisualStyleBackColor = false;
            this.Writefiles.Click += new System.EventHandler(this.Writefiles_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(320, 50);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(468, 374);
            this.textBox1.TabIndex = 2;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Writefiles);
            this.Controls.Add(this.Readfiles);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Readfiles;
        private System.Windows.Forms.Button Writefiles;
        private System.Windows.Forms.TextBox textBox1;
    }
}