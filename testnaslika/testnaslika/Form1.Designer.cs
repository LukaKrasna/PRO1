namespace testnaslika
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
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.datotekaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOdpri = new System.Windows.Forms.ToolStripMenuItem();
            this.btnShrani = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnIzhod = new System.Windows.Forms.ToolStripMenuItem();
            this.vrtenjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zrcaljenjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zrcaliNavpičnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zrcaliVodoravnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.posvetljiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.potemniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.negativToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.vrtenjeZa90ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.hScrollBar1.Location = new System.Drawing.Point(0, 433);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(800, 17);
            this.hScrollBar1.TabIndex = 0;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Dock = System.Windows.Forms.DockStyle.Right;
            this.vScrollBar1.Location = new System.Drawing.Point(783, 24);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 409);
            this.vScrollBar1.TabIndex = 1;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(783, 409);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datotekaToolStripMenuItem,
            this.vrtenjeToolStripMenuItem,
            this.zrcaljenjeToolStripMenuItem,
            this.filterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // datotekaToolStripMenuItem
            // 
            this.datotekaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOdpri,
            this.btnShrani,
            this.toolStripSeparator1,
            this.btnIzhod});
            this.datotekaToolStripMenuItem.Name = "datotekaToolStripMenuItem";
            this.datotekaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.datotekaToolStripMenuItem.Text = "Datoteka";
            // 
            // btnOdpri
            // 
            this.btnOdpri.Name = "btnOdpri";
            this.btnOdpri.Size = new System.Drawing.Size(107, 22);
            this.btnOdpri.Text = "Odpri";
            this.btnOdpri.Click += new System.EventHandler(this.btnOdpri_Click);
            // 
            // btnShrani
            // 
            this.btnShrani.Name = "btnShrani";
            this.btnShrani.Size = new System.Drawing.Size(107, 22);
            this.btnShrani.Text = "Shrani";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(104, 6);
            // 
            // btnIzhod
            // 
            this.btnIzhod.Name = "btnIzhod";
            this.btnIzhod.Size = new System.Drawing.Size(107, 22);
            this.btnIzhod.Text = "Izhod";
            // 
            // vrtenjeToolStripMenuItem
            // 
            this.vrtenjeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vrtenjeZa90ToolStripMenuItem});
            this.vrtenjeToolStripMenuItem.Name = "vrtenjeToolStripMenuItem";
            this.vrtenjeToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.vrtenjeToolStripMenuItem.Text = "Vrtenje";
            // 
            // zrcaljenjeToolStripMenuItem
            // 
            this.zrcaljenjeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zrcaliNavpičnoToolStripMenuItem,
            this.zrcaliVodoravnoToolStripMenuItem});
            this.zrcaljenjeToolStripMenuItem.Name = "zrcaljenjeToolStripMenuItem";
            this.zrcaljenjeToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.zrcaljenjeToolStripMenuItem.Text = "Zrcaljenje";
            // 
            // zrcaliNavpičnoToolStripMenuItem
            // 
            this.zrcaliNavpičnoToolStripMenuItem.Name = "zrcaliNavpičnoToolStripMenuItem";
            this.zrcaliNavpičnoToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.zrcaliNavpičnoToolStripMenuItem.Text = "Zrcali navpično";
            this.zrcaliNavpičnoToolStripMenuItem.Click += new System.EventHandler(this.zrcaliNavpičnoToolStripMenuItem_Click);
            // 
            // zrcaliVodoravnoToolStripMenuItem
            // 
            this.zrcaliVodoravnoToolStripMenuItem.Name = "zrcaliVodoravnoToolStripMenuItem";
            this.zrcaliVodoravnoToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.zrcaliVodoravnoToolStripMenuItem.Text = "Zrcali vodoravno";
            this.zrcaliVodoravnoToolStripMenuItem.Click += new System.EventHandler(this.zrcaliVodoravnoToolStripMenuItem_Click);
            // 
            // filterToolStripMenuItem
            // 
            this.filterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.posvetljiToolStripMenuItem,
            this.potemniToolStripMenuItem,
            this.negativToolStripMenuItem});
            this.filterToolStripMenuItem.Name = "filterToolStripMenuItem";
            this.filterToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.filterToolStripMenuItem.Text = "Filter";
            // 
            // posvetljiToolStripMenuItem
            // 
            this.posvetljiToolStripMenuItem.Name = "posvetljiToolStripMenuItem";
            this.posvetljiToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.posvetljiToolStripMenuItem.Text = "Posvetlji";
            // 
            // potemniToolStripMenuItem
            // 
            this.potemniToolStripMenuItem.Name = "potemniToolStripMenuItem";
            this.potemniToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.potemniToolStripMenuItem.Text = "Potemni";
            // 
            // negativToolStripMenuItem
            // 
            this.negativToolStripMenuItem.Name = "negativToolStripMenuItem";
            this.negativToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.negativToolStripMenuItem.Text = "Negativ";
            this.negativToolStripMenuItem.Click += new System.EventHandler(this.negativToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "slike|*.jpg;*.png;*.pmg|Vse datoteke |**";
            // 
            // vrtenjeZa90ToolStripMenuItem
            // 
            this.vrtenjeZa90ToolStripMenuItem.Name = "vrtenjeZa90ToolStripMenuItem";
            this.vrtenjeZa90ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.vrtenjeZa90ToolStripMenuItem.Text = "Vrtenje za 90°";
            this.vrtenjeZa90ToolStripMenuItem.Click += new System.EventHandler(this.vrtenjeZa90ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem datotekaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnOdpri;
        private System.Windows.Forms.ToolStripMenuItem btnShrani;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem btnIzhod;
        private System.Windows.Forms.ToolStripMenuItem vrtenjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zrcaljenjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filterToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem zrcaliNavpičnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zrcaliVodoravnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem posvetljiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem potemniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem negativToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vrtenjeZa90ToolStripMenuItem;
    }
}

