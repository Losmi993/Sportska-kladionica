namespace KladionicaNova
{
    partial class PocetnaForma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PocetnaForma));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tiketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dogadjajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ligaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipIgreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tiketToolStripMenuItem,
            this.dogadjajToolStripMenuItem,
            this.timToolStripMenuItem,
            this.sportToolStripMenuItem,
            this.ligaToolStripMenuItem,
            this.tipIgreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(310, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tiketToolStripMenuItem
            // 
            this.tiketToolStripMenuItem.Name = "tiketToolStripMenuItem";
            this.tiketToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.tiketToolStripMenuItem.Text = "Tiket";
            this.tiketToolStripMenuItem.Click += new System.EventHandler(this.tiketToolStripMenuItem_Click);
            // 
            // dogadjajToolStripMenuItem
            // 
            this.dogadjajToolStripMenuItem.Name = "dogadjajToolStripMenuItem";
            this.dogadjajToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.dogadjajToolStripMenuItem.Text = "Dogadjaj";
            this.dogadjajToolStripMenuItem.Click += new System.EventHandler(this.dogadjajToolStripMenuItem_Click);
            // 
            // timToolStripMenuItem
            // 
            this.timToolStripMenuItem.Name = "timToolStripMenuItem";
            this.timToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.timToolStripMenuItem.Text = "Tim";
            this.timToolStripMenuItem.Click += new System.EventHandler(this.timToolStripMenuItem_Click);
            // 
            // sportToolStripMenuItem
            // 
            this.sportToolStripMenuItem.Name = "sportToolStripMenuItem";
            this.sportToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.sportToolStripMenuItem.Text = "Sport";
            this.sportToolStripMenuItem.Click += new System.EventHandler(this.sportToolStripMenuItem_Click);
            // 
            // ligaToolStripMenuItem
            // 
            this.ligaToolStripMenuItem.Name = "ligaToolStripMenuItem";
            this.ligaToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.ligaToolStripMenuItem.Text = "Liga";
            this.ligaToolStripMenuItem.Click += new System.EventHandler(this.ligaToolStripMenuItem_Click);
            // 
            // tipIgreToolStripMenuItem
            // 
            this.tipIgreToolStripMenuItem.Name = "tipIgreToolStripMenuItem";
            this.tipIgreToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.tipIgreToolStripMenuItem.Text = "Tip igre";
            this.tipIgreToolStripMenuItem.Click += new System.EventHandler(this.tipIgreToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(52, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 269);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // PocetnaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 273);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PocetnaForma";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.PocetnaForma_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tiketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dogadjajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ligaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipIgreToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

