namespace WindowsFormsApp2
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
            this.grptecaj = new System.Windows.Forms.GroupBox();
            this.rdgbp = new System.Windows.Forms.RadioButton();
            this.RDCHF = new System.Windows.Forms.RadioButton();
            this.rdusd = new System.Windows.Forms.RadioButton();
            this.TXTVNOS = new System.Windows.Forms.TextBox();
            this.txtrez = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblrez = new System.Windows.Forms.Label();
            this.btniračun = new System.Windows.Forms.Button();
            this.btnizhod = new System.Windows.Forms.Button();
            this.btnpočisti = new System.Windows.Forms.Button();
            this.grptecaj.SuspendLayout();
            this.SuspendLayout();
            // 
            // grptecaj
            // 
            this.grptecaj.Controls.Add(this.rdgbp);
            this.grptecaj.Controls.Add(this.RDCHF);
            this.grptecaj.Controls.Add(this.rdusd);
            this.grptecaj.Location = new System.Drawing.Point(12, 12);
            this.grptecaj.Name = "grptecaj";
            this.grptecaj.Size = new System.Drawing.Size(82, 95);
            this.grptecaj.TabIndex = 0;
            this.grptecaj.TabStop = false;
            this.grptecaj.Text = "VALUTE";
            // 
            // rdgbp
            // 
            this.rdgbp.AutoSize = true;
            this.rdgbp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rdgbp.Location = new System.Drawing.Point(18, 68);
            this.rdgbp.Name = "rdgbp";
            this.rdgbp.Size = new System.Drawing.Size(56, 20);
            this.rdgbp.TabIndex = 2;
            this.rdgbp.TabStop = true;
            this.rdgbp.Text = "GBP";
            this.rdgbp.UseVisualStyleBackColor = true;
            this.rdgbp.CheckedChanged += new System.EventHandler(this.rdgbp_CheckedChanged);
            // 
            // RDCHF
            // 
            this.RDCHF.AutoSize = true;
            this.RDCHF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RDCHF.Location = new System.Drawing.Point(18, 44);
            this.RDCHF.Name = "RDCHF";
            this.RDCHF.Size = new System.Drawing.Size(55, 20);
            this.RDCHF.TabIndex = 1;
            this.RDCHF.TabStop = true;
            this.RDCHF.Text = "CHF";
            this.RDCHF.UseVisualStyleBackColor = true;
            this.RDCHF.CheckedChanged += new System.EventHandler(this.RDCHF_CheckedChanged);
            // 
            // rdusd
            // 
            this.rdusd.AutoSize = true;
            this.rdusd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rdusd.Location = new System.Drawing.Point(18, 20);
            this.rdusd.Name = "rdusd";
            this.rdusd.Size = new System.Drawing.Size(57, 20);
            this.rdusd.TabIndex = 0;
            this.rdusd.TabStop = true;
            this.rdusd.Text = "USD";
            this.rdusd.UseVisualStyleBackColor = true;
            this.rdusd.CheckedChanged += new System.EventHandler(this.rdusd_CheckedChanged);
            // 
            // TXTVNOS
            // 
            this.TXTVNOS.Location = new System.Drawing.Point(201, 32);
            this.TXTVNOS.Name = "TXTVNOS";
            this.TXTVNOS.Size = new System.Drawing.Size(159, 20);
            this.TXTVNOS.TabIndex = 1;
            // 
            // txtrez
            // 
            this.txtrez.Location = new System.Drawing.Point(201, 79);
            this.txtrez.Name = "txtrez";
            this.txtrez.Size = new System.Drawing.Size(159, 20);
            this.txtrez.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(366, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "EUR";
            // 
            // lblrez
            // 
            this.lblrez.AutoSize = true;
            this.lblrez.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblrez.Location = new System.Drawing.Point(366, 82);
            this.lblrez.Name = "lblrez";
            this.lblrez.Size = new System.Drawing.Size(0, 16);
            this.lblrez.TabIndex = 4;
            // 
            // btniračun
            // 
            this.btniračun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btniračun.Location = new System.Drawing.Point(54, 135);
            this.btniračun.Name = "btniračun";
            this.btniračun.Size = new System.Drawing.Size(100, 32);
            this.btniračun.TabIndex = 5;
            this.btniračun.Text = "IZRAČUNAJ";
            this.btniračun.UseVisualStyleBackColor = true;
            this.btniračun.Click += new System.EventHandler(this.btniračun_Click);
            // 
            // btnizhod
            // 
            this.btnizhod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnizhod.Location = new System.Drawing.Point(160, 135);
            this.btnizhod.Name = "btnizhod";
            this.btnizhod.Size = new System.Drawing.Size(100, 32);
            this.btnizhod.TabIndex = 6;
            this.btnizhod.Text = "IZHOD";
            this.btnizhod.UseVisualStyleBackColor = true;
            this.btnizhod.Click += new System.EventHandler(this.btnizhod_Click);
            // 
            // btnpočisti
            // 
            this.btnpočisti.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnpočisti.Location = new System.Drawing.Point(266, 135);
            this.btnpočisti.Name = "btnpočisti";
            this.btnpočisti.Size = new System.Drawing.Size(100, 32);
            this.btnpočisti.TabIndex = 7;
            this.btnpočisti.Text = "POČISTI";
            this.btnpočisti.UseVisualStyleBackColor = true;
            this.btnpočisti.Click += new System.EventHandler(this.btnpočisti_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 173);
            this.Controls.Add(this.btnpočisti);
            this.Controls.Add(this.btnizhod);
            this.Controls.Add(this.btniračun);
            this.Controls.Add(this.lblrez);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtrez);
            this.Controls.Add(this.TXTVNOS);
            this.Controls.Add(this.grptecaj);
            this.Name = "Form1";
            this.Text = "TEČAJNA LISTA";
            this.grptecaj.ResumeLayout(false);
            this.grptecaj.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grptecaj;
        private System.Windows.Forms.RadioButton rdgbp;
        private System.Windows.Forms.RadioButton RDCHF;
        private System.Windows.Forms.RadioButton rdusd;
        private System.Windows.Forms.TextBox TXTVNOS;
        private System.Windows.Forms.TextBox txtrez;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblrez;
        private System.Windows.Forms.Button btniračun;
        private System.Windows.Forms.Button btnizhod;
        private System.Windows.Forms.Button btnpočisti;
    }
}

