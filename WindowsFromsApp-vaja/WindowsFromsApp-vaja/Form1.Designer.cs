namespace WindowsFromsApp_vaja
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
            this.stranica = new System.Windows.Forms.Label();
            this.obsKvardata = new System.Windows.Forms.Label();
            this.ploKvadrata = new System.Windows.Forms.Label();
            this.txtStranica = new System.Windows.Forms.TextBox();
            this.txtObsegKv = new System.Windows.Forms.TextBox();
            this.txtPloščinaKv = new System.Windows.Forms.TextBox();
            this.btnKvadrat = new System.Windows.Forms.Button();
            this.polmer = new System.Windows.Forms.Label();
            this.obsegKroga = new System.Windows.Forms.Label();
            this.ploKroga = new System.Windows.Forms.Label();
            this.txtPolmer = new System.Windows.Forms.TextBox();
            this.txtObsegKrog = new System.Windows.Forms.TextBox();
            this.txtPloKrog = new System.Windows.Forms.TextBox();
            this.btnKrog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // stranica
            // 
            this.stranica.AutoSize = true;
            this.stranica.Location = new System.Drawing.Point(23, 25);
            this.stranica.Name = "stranica";
            this.stranica.Size = new System.Drawing.Size(49, 13);
            this.stranica.TabIndex = 0;
            this.stranica.Text = "Stranica:";
            // 
            // obsKvardata
            // 
            this.obsKvardata.AutoSize = true;
            this.obsKvardata.Location = new System.Drawing.Point(23, 49);
            this.obsKvardata.Name = "obsKvardata";
            this.obsKvardata.Size = new System.Drawing.Size(86, 13);
            this.obsKvardata.TabIndex = 1;
            this.obsKvardata.Text = "Obseg kvardata:";
            // 
            // ploKvadrata
            // 
            this.ploKvadrata.AutoSize = true;
            this.ploKvadrata.Location = new System.Drawing.Point(23, 73);
            this.ploKvadrata.Name = "ploKvadrata";
            this.ploKvadrata.Size = new System.Drawing.Size(95, 13);
            this.ploKvadrata.TabIndex = 2;
            this.ploKvadrata.Text = "Ploščina kvadrata:";
            // 
            // txtStranica
            // 
            this.txtStranica.Location = new System.Drawing.Point(122, 22);
            this.txtStranica.Name = "txtStranica";
            this.txtStranica.Size = new System.Drawing.Size(100, 20);
            this.txtStranica.TabIndex = 3;
            // 
            // txtObsegKv
            // 
            this.txtObsegKv.Location = new System.Drawing.Point(122, 46);
            this.txtObsegKv.Name = "txtObsegKv";
            this.txtObsegKv.ReadOnly = true;
            this.txtObsegKv.Size = new System.Drawing.Size(100, 20);
            this.txtObsegKv.TabIndex = 4;
            this.txtObsegKv.TabStop = false;
            // 
            // txtPloščinaKv
            // 
            this.txtPloščinaKv.Location = new System.Drawing.Point(122, 70);
            this.txtPloščinaKv.Name = "txtPloščinaKv";
            this.txtPloščinaKv.ReadOnly = true;
            this.txtPloščinaKv.Size = new System.Drawing.Size(100, 20);
            this.txtPloščinaKv.TabIndex = 5;
            this.txtPloščinaKv.TabStop = false;
            // 
            // btnKvadrat
            // 
            this.btnKvadrat.Location = new System.Drawing.Point(26, 104);
            this.btnKvadrat.Name = "btnKvadrat";
            this.btnKvadrat.Size = new System.Drawing.Size(98, 23);
            this.btnKvadrat.TabIndex = 6;
            this.btnKvadrat.Text = "Izračunaj kvadrat";
            this.btnKvadrat.UseVisualStyleBackColor = true;
            this.btnKvadrat.Click += new System.EventHandler(this.btnKvadrat_Click);
            // 
            // polmer
            // 
            this.polmer.AutoSize = true;
            this.polmer.Location = new System.Drawing.Point(26, 149);
            this.polmer.Name = "polmer";
            this.polmer.Size = new System.Drawing.Size(39, 13);
            this.polmer.TabIndex = 7;
            this.polmer.Text = "Polmer";
            // 
            // obsegKroga
            // 
            this.obsegKroga.AutoSize = true;
            this.obsegKroga.Location = new System.Drawing.Point(26, 177);
            this.obsegKroga.Name = "obsegKroga";
            this.obsegKroga.Size = new System.Drawing.Size(68, 13);
            this.obsegKroga.TabIndex = 8;
            this.obsegKroga.Text = "Obseg kroga";
            // 
            // ploKroga
            // 
            this.ploKroga.AutoSize = true;
            this.ploKroga.Location = new System.Drawing.Point(26, 205);
            this.ploKroga.Name = "ploKroga";
            this.ploKroga.Size = new System.Drawing.Size(77, 13);
            this.ploKroga.TabIndex = 9;
            this.ploKroga.Text = "Ploščina kroga";
            // 
            // txtPolmer
            // 
            this.txtPolmer.Location = new System.Drawing.Point(122, 146);
            this.txtPolmer.Name = "txtPolmer";
            this.txtPolmer.Size = new System.Drawing.Size(100, 20);
            this.txtPolmer.TabIndex = 10;
            // 
            // txtObsegKrog
            // 
            this.txtObsegKrog.Location = new System.Drawing.Point(122, 174);
            this.txtObsegKrog.Name = "txtObsegKrog";
            this.txtObsegKrog.ReadOnly = true;
            this.txtObsegKrog.Size = new System.Drawing.Size(100, 20);
            this.txtObsegKrog.TabIndex = 11;
            this.txtObsegKrog.TabStop = false;
            // 
            // txtPloKrog
            // 
            this.txtPloKrog.Location = new System.Drawing.Point(122, 202);
            this.txtPloKrog.Name = "txtPloKrog";
            this.txtPloKrog.ReadOnly = true;
            this.txtPloKrog.Size = new System.Drawing.Size(100, 20);
            this.txtPloKrog.TabIndex = 12;
            this.txtPloKrog.TabStop = false;
            // 
            // btnKrog
            // 
            this.btnKrog.Location = new System.Drawing.Point(26, 236);
            this.btnKrog.Name = "btnKrog";
            this.btnKrog.Size = new System.Drawing.Size(98, 23);
            this.btnKrog.TabIndex = 13;
            this.btnKrog.Text = "Izračunaj krog";
            this.btnKrog.UseVisualStyleBackColor = true;
            this.btnKrog.Click += new System.EventHandler(this.btnKrog_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 292);
            this.Controls.Add(this.btnKrog);
            this.Controls.Add(this.txtPloKrog);
            this.Controls.Add(this.txtObsegKrog);
            this.Controls.Add(this.txtPolmer);
            this.Controls.Add(this.ploKroga);
            this.Controls.Add(this.obsegKroga);
            this.Controls.Add(this.polmer);
            this.Controls.Add(this.btnKvadrat);
            this.Controls.Add(this.txtPloščinaKv);
            this.Controls.Add(this.txtObsegKv);
            this.Controls.Add(this.txtStranica);
            this.Controls.Add(this.ploKvadrata);
            this.Controls.Add(this.obsKvardata);
            this.Controls.Add(this.stranica);
            this.Name = "Form1";
            this.Text = "Kvadrat in krog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label stranica;
        private System.Windows.Forms.Label obsKvardata;
        private System.Windows.Forms.Label ploKvadrata;
        private System.Windows.Forms.TextBox txtStranica;
        private System.Windows.Forms.TextBox txtObsegKv;
        private System.Windows.Forms.TextBox txtPloščinaKv;
        private System.Windows.Forms.Button btnKvadrat;
        private System.Windows.Forms.Label polmer;
        private System.Windows.Forms.Label obsegKroga;
        private System.Windows.Forms.Label ploKroga;
        private System.Windows.Forms.TextBox txtPolmer;
        private System.Windows.Forms.TextBox txtObsegKrog;
        private System.Windows.Forms.TextBox txtPloKrog;
        private System.Windows.Forms.Button btnKrog;
    }
}

