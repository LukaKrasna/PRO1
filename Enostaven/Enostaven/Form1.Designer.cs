﻿namespace Enostaven
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrvo = new System.Windows.Forms.TextBox();
            this.txtDrugo = new System.Windows.Forms.TextBox();
            this.rezultat = new System.Windows.Forms.TextBox();
            this.btnIzračunaj = new System.Windows.Forms.Button();
            this.btnPočisti = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radPlus = new System.Windows.Forms.RadioButton();
            this.radMinus = new System.Windows.Forms.RadioButton();
            this.radKrat = new System.Windows.Forms.RadioButton();
            this.radDeljeno = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prvo število:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Drugo število:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rezultat:";
            // 
            // txtPrvo
            // 
            this.txtPrvo.Location = new System.Drawing.Point(114, 15);
            this.txtPrvo.Name = "txtPrvo";
            this.txtPrvo.Size = new System.Drawing.Size(100, 20);
            this.txtPrvo.TabIndex = 3;
            // 
            // txtDrugo
            // 
            this.txtDrugo.Location = new System.Drawing.Point(114, 44);
            this.txtDrugo.Name = "txtDrugo";
            this.txtDrugo.Size = new System.Drawing.Size(100, 20);
            this.txtDrugo.TabIndex = 4;
            // 
            // rezultat
            // 
            this.rezultat.Location = new System.Drawing.Point(114, 76);
            this.rezultat.Name = "rezultat";
            this.rezultat.ReadOnly = true;
            this.rezultat.Size = new System.Drawing.Size(100, 20);
            this.rezultat.TabIndex = 5;
            this.rezultat.TabStop = false;
            // 
            // btnIzračunaj
            // 
            this.btnIzračunaj.Location = new System.Drawing.Point(18, 111);
            this.btnIzračunaj.Name = "btnIzračunaj";
            this.btnIzračunaj.Size = new System.Drawing.Size(75, 23);
            this.btnIzračunaj.TabIndex = 6;
            this.btnIzračunaj.Text = "Izračunaj";
            this.btnIzračunaj.UseVisualStyleBackColor = true;
            this.btnIzračunaj.Click += new System.EventHandler(this.btnIzračunajKlik);
            // 
            // btnPočisti
            // 
            this.btnPočisti.Location = new System.Drawing.Point(164, 110);
            this.btnPočisti.Name = "btnPočisti";
            this.btnPočisti.Size = new System.Drawing.Size(75, 23);
            this.btnPočisti.TabIndex = 7;
            this.btnPočisti.Text = "Počisti vse";
            this.btnPočisti.UseVisualStyleBackColor = true;
            this.btnPočisti.Click += new System.EventHandler(this.btnPočisti_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radDeljeno);
            this.groupBox1.Controls.Add(this.radKrat);
            this.groupBox1.Controls.Add(this.radMinus);
            this.groupBox1.Controls.Add(this.radPlus);
            this.groupBox1.Location = new System.Drawing.Point(284, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(93, 119);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operacija";
            // 
            // radPlus
            // 
            this.radPlus.AutoSize = true;
            this.radPlus.Checked = true;
            this.radPlus.Location = new System.Drawing.Point(7, 20);
            this.radPlus.Name = "radPlus";
            this.radPlus.Size = new System.Drawing.Size(54, 17);
            this.radPlus.TabIndex = 0;
            this.radPlus.TabStop = true;
            this.radPlus.Text = "Seštej";
            this.radPlus.UseVisualStyleBackColor = true;
            this.radPlus.Click += new System.EventHandler(this.radPlus_Click);
            // 
            // radMinus
            // 
            this.radMinus.AutoSize = true;
            this.radMinus.Location = new System.Drawing.Point(7, 42);
            this.radMinus.Name = "radMinus";
            this.radMinus.Size = new System.Drawing.Size(55, 17);
            this.radMinus.TabIndex = 1;
            this.radMinus.TabStop = true;
            this.radMinus.Text = "Odštej";
            this.radMinus.UseVisualStyleBackColor = true;
            this.radMinus.Click += new System.EventHandler(this.radMinus_Click);
            // 
            // radKrat
            // 
            this.radKrat.AutoSize = true;
            this.radKrat.Location = new System.Drawing.Point(7, 66);
            this.radKrat.Name = "radKrat";
            this.radKrat.Size = new System.Drawing.Size(59, 17);
            this.radKrat.TabIndex = 2;
            this.radKrat.TabStop = true;
            this.radKrat.Text = "Zmnoži";
            this.radKrat.UseVisualStyleBackColor = true;
            this.radKrat.CheckedChanged += new System.EventHandler(this.radKrat_CheckedChanged);
            // 
            // radDeljeno
            // 
            this.radDeljeno.AutoSize = true;
            this.radDeljeno.Location = new System.Drawing.Point(7, 90);
            this.radDeljeno.Name = "radDeljeno";
            this.radDeljeno.Size = new System.Drawing.Size(45, 17);
            this.radDeljeno.TabIndex = 3;
            this.radDeljeno.TabStop = true;
            this.radDeljeno.Text = "Delji";
            this.radDeljeno.UseVisualStyleBackColor = true;
            this.radDeljeno.CheckedChanged += new System.EventHandler(this.radDeljeno_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 167);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPočisti);
            this.Controls.Add(this.btnIzračunaj);
            this.Controls.Add(this.rezultat);
            this.Controls.Add(this.txtDrugo);
            this.Controls.Add(this.txtPrvo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Računanje";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrvo;
        private System.Windows.Forms.TextBox txtDrugo;
        private System.Windows.Forms.TextBox rezultat;
        private System.Windows.Forms.Button btnIzračunaj;
        private System.Windows.Forms.Button btnPočisti;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radDeljeno;
        private System.Windows.Forms.RadioButton radKrat;
        private System.Windows.Forms.RadioButton radMinus;
        private System.Windows.Forms.RadioButton radPlus;
    }
}

