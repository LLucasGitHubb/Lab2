namespace Lab2
{
    partial class Form4
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
            this.read = new System.Windows.Forms.Button();
            this.calculate = new System.Windows.Forms.Button();
            this.tb_expression = new System.Windows.Forms.TextBox();
            this.tb_result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // read
            // 
            this.read.AutoSize = true;
            this.read.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.read.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.read.Location = new System.Drawing.Point(30, 30);
            this.read.Name = "read";
            this.read.Size = new System.Drawing.Size(75, 29);
            this.read.TabIndex = 1;
            this.read.Text = "Read";
            this.read.UseVisualStyleBackColor = false;
            this.read.Click += new System.EventHandler(this.read_Click);
            // 
            // calculate
            // 
            this.calculate.AutoSize = true;
            this.calculate.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.calculate.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculate.Location = new System.Drawing.Point(418, 30);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(90, 29);
            this.calculate.TabIndex = 6;
            this.calculate.Text = "Calculate";
            this.calculate.UseVisualStyleBackColor = false;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // tb_expression
            // 
            this.tb_expression.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_expression.Location = new System.Drawing.Point(30, 96);
            this.tb_expression.Multiline = true;
            this.tb_expression.Name = "tb_expression";
            this.tb_expression.Size = new System.Drawing.Size(719, 40);
            this.tb_expression.TabIndex = 7;
            // 
            // tb_result
            // 
            this.tb_result.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_result.Location = new System.Drawing.Point(30, 163);
            this.tb_result.Multiline = true;
            this.tb_result.Name = "tb_result";
            this.tb_result.Size = new System.Drawing.Size(719, 275);
            this.tb_result.TabIndex = 8;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_result);
            this.Controls.Add(this.tb_expression);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.read);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button read;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.TextBox tb_expression;
        private System.Windows.Forms.TextBox tb_result;
    }
}