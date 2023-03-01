namespace WindowsFormsApp1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnbarva = new System.Windows.Forms.Button();
            this.btnfont = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(58, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(349, 26);
            this.textBox1.TabIndex = 0;
            // 
            // btnbarva
            // 
            this.btnbarva.Location = new System.Drawing.Point(58, 140);
            this.btnbarva.Name = "btnbarva";
            this.btnbarva.Size = new System.Drawing.Size(102, 43);
            this.btnbarva.TabIndex = 1;
            this.btnbarva.Text = "barva";
            this.btnbarva.UseVisualStyleBackColor = true;
            this.btnbarva.Click += new System.EventHandler(this.btnbarva_Click);
            // 
            // btnfont
            // 
            this.btnfont.Location = new System.Drawing.Point(321, 140);
            this.btnfont.Name = "btnfont";
            this.btnfont.Size = new System.Drawing.Size(85, 43);
            this.btnfont.TabIndex = 2;
            this.btnfont.Text = "pisava";
            this.btnfont.UseVisualStyleBackColor = true;
            this.btnfont.Click += new System.EventHandler(this.btnfont_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 228);
            this.Controls.Add(this.btnfont);
            this.Controls.Add(this.btnbarva);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnbarva;
        private System.Windows.Forms.Button btnfont;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}

