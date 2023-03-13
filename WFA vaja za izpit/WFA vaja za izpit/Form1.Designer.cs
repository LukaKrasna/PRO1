namespace WFA_vaja_za_izpit
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
            this.grpTečaji = new System.Windows.Forms.GroupBox();
            this.radGBP = new System.Windows.Forms.RadioButton();
            this.radJPY = new System.Windows.Forms.RadioButton();
            this.radUSD = new System.Windows.Forms.RadioButton();
            this.txtVnos = new System.Windows.Forms.TextBox();
            this.txtRezultat = new System.Windows.Forms.TextBox();
            this.lblVnos = new System.Windows.Forms.Label();
            this.lblRezultat = new System.Windows.Forms.Label();
            this.btnIzračun = new System.Windows.Forms.Button();
            this.btnIzbriši = new System.Windows.Forms.Button();
            this.grpTečaji.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpTečaji
            // 
            this.grpTečaji.Controls.Add(this.radGBP);
            this.grpTečaji.Controls.Add(this.radJPY);
            this.grpTečaji.Controls.Add(this.radUSD);
            this.grpTečaji.Location = new System.Drawing.Point(12, 12);
            this.grpTečaji.Name = "grpTečaji";
            this.grpTečaji.Size = new System.Drawing.Size(62, 100);
            this.grpTečaji.TabIndex = 0;
            this.grpTečaji.TabStop = false;
            this.grpTečaji.Text = "Tečaji";
            // 
            // radGBP
            // 
            this.radGBP.AutoSize = true;
            this.radGBP.Location = new System.Drawing.Point(7, 68);
            this.radGBP.Name = "radGBP";
            this.radGBP.Size = new System.Drawing.Size(47, 17);
            this.radGBP.TabIndex = 2;
            this.radGBP.Text = "GBP";
            this.radGBP.UseVisualStyleBackColor = true;
            // 
            // radJPY
            // 
            this.radJPY.AutoSize = true;
            this.radJPY.Location = new System.Drawing.Point(7, 44);
            this.radJPY.Name = "radJPY";
            this.radJPY.Size = new System.Drawing.Size(44, 17);
            this.radJPY.TabIndex = 1;
            this.radJPY.Text = "JPY";
            this.radJPY.UseVisualStyleBackColor = true;
            // 
            // radUSD
            // 
            this.radUSD.AutoSize = true;
            this.radUSD.Checked = true;
            this.radUSD.Location = new System.Drawing.Point(7, 20);
            this.radUSD.Name = "radUSD";
            this.radUSD.Size = new System.Drawing.Size(48, 17);
            this.radUSD.TabIndex = 0;
            this.radUSD.TabStop = true;
            this.radUSD.Text = "USD";
            this.radUSD.UseVisualStyleBackColor = true;
            // 
            // txtVnos
            // 
            this.txtVnos.Location = new System.Drawing.Point(108, 31);
            this.txtVnos.Name = "txtVnos";
            this.txtVnos.Size = new System.Drawing.Size(100, 20);
            this.txtVnos.TabIndex = 1;
            // 
            // txtRezultat
            // 
            this.txtRezultat.Location = new System.Drawing.Point(108, 58);
            this.txtRezultat.Name = "txtRezultat";
            this.txtRezultat.ReadOnly = true;
            this.txtRezultat.Size = new System.Drawing.Size(100, 20);
            this.txtRezultat.TabIndex = 2;
            this.txtRezultat.TabStop = false;
            // 
            // lblVnos
            // 
            this.lblVnos.AutoSize = true;
            this.lblVnos.Location = new System.Drawing.Point(214, 38);
            this.lblVnos.Name = "lblVnos";
            this.lblVnos.Size = new System.Drawing.Size(30, 13);
            this.lblVnos.TabIndex = 3;
            this.lblVnos.Text = "EUR";
            // 
            // lblRezultat
            // 
            this.lblRezultat.AutoSize = true;
            this.lblRezultat.Location = new System.Drawing.Point(215, 64);
            this.lblRezultat.Name = "lblRezultat";
            this.lblRezultat.Size = new System.Drawing.Size(46, 13);
            this.lblRezultat.TabIndex = 4;
            this.lblRezultat.Text = "Rezultat";
            // 
            // btnIzračun
            // 
            this.btnIzračun.Location = new System.Drawing.Point(19, 136);
            this.btnIzračun.Name = "btnIzračun";
            this.btnIzračun.Size = new System.Drawing.Size(75, 23);
            this.btnIzračun.TabIndex = 5;
            this.btnIzračun.Text = "Izračun";
            this.btnIzračun.UseVisualStyleBackColor = true;
            this.btnIzračun.Click += new System.EventHandler(this.btnIzračun_Click);
            // 
            // btnIzbriši
            // 
            this.btnIzbriši.Location = new System.Drawing.Point(122, 135);
            this.btnIzbriši.Name = "btnIzbriši";
            this.btnIzbriši.Size = new System.Drawing.Size(75, 23);
            this.btnIzbriši.TabIndex = 6;
            this.btnIzbriši.Text = "Izbriši";
            this.btnIzbriši.UseVisualStyleBackColor = true;
            this.btnIzbriši.Click += new System.EventHandler(this.btnIzbriši_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 170);
            this.Controls.Add(this.btnIzbriši);
            this.Controls.Add(this.btnIzračun);
            this.Controls.Add(this.lblRezultat);
            this.Controls.Add(this.lblVnos);
            this.Controls.Add(this.txtRezultat);
            this.Controls.Add(this.txtVnos);
            this.Controls.Add(this.grpTečaji);
            this.Name = "Form1";
            this.Text = "Pretvornik tečajev";
            this.grpTečaji.ResumeLayout(false);
            this.grpTečaji.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpTečaji;
        private System.Windows.Forms.RadioButton radGBP;
        private System.Windows.Forms.RadioButton radJPY;
        private System.Windows.Forms.RadioButton radUSD;
        private System.Windows.Forms.TextBox txtVnos;
        private System.Windows.Forms.TextBox txtRezultat;
        private System.Windows.Forms.Label lblVnos;
        private System.Windows.Forms.Label lblRezultat;
        private System.Windows.Forms.Button btnIzračun;
        private System.Windows.Forms.Button btnIzbriši;
    }
}

