namespace Kalkulator_ocen_v_WFA
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radAng = new System.Windows.Forms.RadioButton();
            this.radMat = new System.Windows.Forms.RadioButton();
            this.radNar = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDelni1 = new System.Windows.Forms.TextBox();
            this.txtDelni2 = new System.Windows.Forms.TextBox();
            this.txtSeminar = new System.Windows.Forms.TextBox();
            this.txtUstna = new System.Windows.Forms.TextBox();
            this.btnIzračunaj = new System.Windows.Forms.Button();
            this.btnPoenostavi = new System.Windows.Forms.Button();
            this.labRezultat = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radNar);
            this.groupBox1.Controls.Add(this.radMat);
            this.groupBox1.Controls.Add(this.radAng);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(106, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Oddelek študenta";
            // 
            // radAng
            // 
            this.radAng.AutoSize = true;
            this.radAng.Checked = true;
            this.radAng.Location = new System.Drawing.Point(7, 20);
            this.radAng.Name = "radAng";
            this.radAng.Size = new System.Drawing.Size(77, 17);
            this.radAng.TabIndex = 0;
            this.radAng.TabStop = true;
            this.radAng.Text = "Angleščina";
            this.radAng.UseVisualStyleBackColor = true;
            this.radAng.CheckedChanged += new System.EventHandler(this.radAng_CheckedChanged);
            // 
            // radMat
            // 
            this.radMat.AutoSize = true;
            this.radMat.Location = new System.Drawing.Point(7, 44);
            this.radMat.Name = "radMat";
            this.radMat.Size = new System.Drawing.Size(80, 17);
            this.radMat.TabIndex = 1;
            this.radMat.Text = "Matematika";
            this.radMat.UseVisualStyleBackColor = true;
            this.radMat.CheckedChanged += new System.EventHandler(this.radMat_CheckedChanged);
            // 
            // radNar
            // 
            this.radNar.AutoSize = true;
            this.radNar.Location = new System.Drawing.Point(7, 68);
            this.radNar.Name = "radNar";
            this.radNar.Size = new System.Drawing.Size(87, 17);
            this.radNar.TabIndex = 2;
            this.radNar.Text = "Naravoslovje";
            this.radNar.UseVisualStyleBackColor = true;
            this.radNar.CheckedChanged += new System.EventHandler(this.radNar_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtUstna);
            this.groupBox2.Controls.Add(this.txtSeminar);
            this.groupBox2.Controls.Add(this.txtDelni2);
            this.groupBox2.Controls.Add(this.txtDelni1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(193, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(187, 116);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Študent angleščine";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Delni 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Delni 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Seminar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ustna";
            // 
            // txtDelni1
            // 
            this.txtDelni1.Location = new System.Drawing.Point(62, 19);
            this.txtDelni1.Name = "txtDelni1";
            this.txtDelni1.Size = new System.Drawing.Size(100, 20);
            this.txtDelni1.TabIndex = 5;
            // 
            // txtDelni2
            // 
            this.txtDelni2.Location = new System.Drawing.Point(62, 41);
            this.txtDelni2.Name = "txtDelni2";
            this.txtDelni2.Size = new System.Drawing.Size(100, 20);
            this.txtDelni2.TabIndex = 6;
            // 
            // txtSeminar
            // 
            this.txtSeminar.Location = new System.Drawing.Point(62, 63);
            this.txtSeminar.Name = "txtSeminar";
            this.txtSeminar.Size = new System.Drawing.Size(100, 20);
            this.txtSeminar.TabIndex = 8;
            // 
            // txtUstna
            // 
            this.txtUstna.Location = new System.Drawing.Point(62, 85);
            this.txtUstna.Name = "txtUstna";
            this.txtUstna.Size = new System.Drawing.Size(100, 20);
            this.txtUstna.TabIndex = 9;
            // 
            // btnIzračunaj
            // 
            this.btnIzračunaj.Location = new System.Drawing.Point(13, 137);
            this.btnIzračunaj.Name = "btnIzračunaj";
            this.btnIzračunaj.Size = new System.Drawing.Size(75, 23);
            this.btnIzračunaj.TabIndex = 2;
            this.btnIzračunaj.Text = "Izračunaj";
            this.btnIzračunaj.UseVisualStyleBackColor = true;
            this.btnIzračunaj.Click += new System.EventHandler(this.btnIzračunaj_Click);
            // 
            // btnPoenostavi
            // 
            this.btnPoenostavi.Location = new System.Drawing.Point(13, 167);
            this.btnPoenostavi.Name = "btnPoenostavi";
            this.btnPoenostavi.Size = new System.Drawing.Size(75, 23);
            this.btnPoenostavi.TabIndex = 3;
            this.btnPoenostavi.Text = "Ponastavi";
            this.btnPoenostavi.UseVisualStyleBackColor = true;
            this.btnPoenostavi.Click += new System.EventHandler(this.btnPoenostavi_Click);
            // 
            // labRezultat
            // 
            this.labRezultat.AutoSize = true;
            this.labRezultat.Location = new System.Drawing.Point(111, 142);
            this.labRezultat.Name = "labRezultat";
            this.labRezultat.Size = new System.Drawing.Size(35, 13);
            this.labRezultat.TabIndex = 4;
            this.labRezultat.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labRezultat);
            this.Controls.Add(this.btnPoenostavi);
            this.Controls.Add(this.btnIzračunaj);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Kalkulator ocen";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radNar;
        private System.Windows.Forms.RadioButton radMat;
        private System.Windows.Forms.RadioButton radAng;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtUstna;
        private System.Windows.Forms.TextBox txtSeminar;
        private System.Windows.Forms.TextBox txtDelni2;
        private System.Windows.Forms.TextBox txtDelni1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIzračunaj;
        private System.Windows.Forms.Button btnPoenostavi;
        private System.Windows.Forms.Label labRezultat;
    }
}

