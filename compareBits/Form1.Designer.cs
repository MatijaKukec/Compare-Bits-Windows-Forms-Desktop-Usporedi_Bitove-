namespace compareBits
{
    partial class Form1
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
            this.UsporediGumb = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.InputBits1 = new System.Windows.Forms.Label();
            this.InputBits2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UsporediGumb
            // 
            this.UsporediGumb.Location = new System.Drawing.Point(609, 123);
            this.UsporediGumb.Name = "UsporediGumb";
            this.UsporediGumb.Size = new System.Drawing.Size(98, 43);
            this.UsporediGumb.TabIndex = 0;
            this.UsporediGumb.Text = "Usporedi";
            this.UsporediGumb.UseVisualStyleBackColor = true;
            this.UsporediGumb.Click += new System.EventHandler(this.UsporediGumb_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox1.Location = new System.Drawing.Point(32, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(484, 26);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(32, 195);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(484, 26);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(567, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Rezultat";
            // 
            // InputBits1
            // 
            this.InputBits1.AutoSize = true;
            this.InputBits1.Location = new System.Drawing.Point(175, 99);
            this.InputBits1.Name = "InputBits1";
            this.InputBits1.Size = new System.Drawing.Size(100, 20);
            this.InputBits1.TabIndex = 6;
            this.InputBits1.Text = "Input Bit(s) 1";
            // 
            // InputBits2
            // 
            this.InputBits2.AutoSize = true;
            this.InputBits2.Location = new System.Drawing.Point(179, 237);
            this.InputBits2.Name = "InputBits2";
            this.InputBits2.Size = new System.Drawing.Size(100, 20);
            this.InputBits2.TabIndex = 7;
            this.InputBits2.Text = "Input Bit(s) 2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.InputBits2);
            this.Controls.Add(this.InputBits1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.UsporediGumb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UsporediGumb;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label InputBits1;
        private System.Windows.Forms.Label InputBits2;
    }
}

