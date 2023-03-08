namespace Prva_aplikacija
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
            this.btnPrvi = new System.Windows.Forms.Button();
            this.labNapis = new System.Windows.Forms.Label();
            this.btnŠtevec = new System.Windows.Forms.Button();
            this.labŠtevec = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPrvi
            // 
            this.btnPrvi.Location = new System.Drawing.Point(68, 58);
            this.btnPrvi.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrvi.Name = "btnPrvi";
            this.btnPrvi.Size = new System.Drawing.Size(100, 101);
            this.btnPrvi.TabIndex = 0;
            this.btnPrvi.Text = "Klikni me";
            this.btnPrvi.UseVisualStyleBackColor = true;
            this.btnPrvi.Click += new System.EventHandler(this.button1_Click);
            // 
            // labNapis
            // 
            this.labNapis.AutoSize = true;
            this.labNapis.Location = new System.Drawing.Point(118, 234);
            this.labNapis.Name = "labNapis";
            this.labNapis.Size = new System.Drawing.Size(44, 16);
            this.labNapis.TabIndex = 1;
            this.labNapis.Text = "label1";
            // 
            // btnŠtevec
            // 
            this.btnŠtevec.Location = new System.Drawing.Point(225, 58);
            this.btnŠtevec.Name = "btnŠtevec";
            this.btnŠtevec.Size = new System.Drawing.Size(102, 101);
            this.btnŠtevec.TabIndex = 2;
            this.btnŠtevec.Text = "Štej klike";
            this.btnŠtevec.UseVisualStyleBackColor = true;
            this.btnŠtevec.Click += new System.EventHandler(this.Štej);
            // 
            // labŠtevec
            // 
            this.labŠtevec.AutoSize = true;
            this.labŠtevec.Location = new System.Drawing.Point(291, 234);
            this.labŠtevec.Name = "labŠtevec";
            this.labŠtevec.Size = new System.Drawing.Size(44, 16);
            this.labŠtevec.TabIndex = 3;
            this.labŠtevec.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 508);
            this.Controls.Add(this.labŠtevec);
            this.Controls.Add(this.btnŠtevec);
            this.Controls.Add(this.labNapis);
            this.Controls.Add(this.btnPrvi);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrvi;
        private System.Windows.Forms.Label labNapis;
        private System.Windows.Forms.Button btnŠtevec;
        private System.Windows.Forms.Label labŠtevec;
    }
}

