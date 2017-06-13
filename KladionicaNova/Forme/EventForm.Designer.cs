namespace KladionicaNova.Forme
{
    partial class EventForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventForm));
            this.SaveButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SportIDComboBox = new System.Windows.Forms.ComboBox();
            this.QuotaTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TeamIDComboBox = new System.Windows.Forms.ComboBox();
            this.TeamID1ComboBox = new System.Windows.Forms.ComboBox();
            this.GameTypeIDComboBox = new System.Windows.Forms.ComboBox();
            this.LeagueIDComboBox = new System.Windows.Forms.ComboBox();
            this.EventCancelButton = new System.Windows.Forms.Button();
            this.ViewButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.EventDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(133, 194);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 0;
            this.SaveButton.Text = "Sacuvaj";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Naziv sporta:";
            // 
            // SportIDComboBox
            // 
            this.SportIDComboBox.FormattingEnabled = true;
            this.SportIDComboBox.Location = new System.Drawing.Point(100, 29);
            this.SportIDComboBox.Name = "SportIDComboBox";
            this.SportIDComboBox.Size = new System.Drawing.Size(121, 21);
            this.SportIDComboBox.TabIndex = 2;
            // 
            // QuotaTextBox
            // 
            this.QuotaTextBox.Location = new System.Drawing.Point(464, 123);
            this.QuotaTextBox.Name = "QuotaTextBox";
            this.QuotaTextBox.Size = new System.Drawing.Size(121, 20);
            this.QuotaTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ime tima:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ime tima:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(324, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Naziv lige:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(324, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tip igre:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(324, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Kvota:";
            // 
            // TeamIDComboBox
            // 
            this.TeamIDComboBox.FormattingEnabled = true;
            this.TeamIDComboBox.Location = new System.Drawing.Point(100, 69);
            this.TeamIDComboBox.Name = "TeamIDComboBox";
            this.TeamIDComboBox.Size = new System.Drawing.Size(121, 21);
            this.TeamIDComboBox.TabIndex = 9;
            // 
            // TeamID1ComboBox
            // 
            this.TeamID1ComboBox.FormattingEnabled = true;
            this.TeamID1ComboBox.Location = new System.Drawing.Point(100, 114);
            this.TeamID1ComboBox.Name = "TeamID1ComboBox";
            this.TeamID1ComboBox.Size = new System.Drawing.Size(121, 21);
            this.TeamID1ComboBox.TabIndex = 10;
            // 
            // GameTypeIDComboBox
            // 
            this.GameTypeIDComboBox.FormattingEnabled = true;
            this.GameTypeIDComboBox.Location = new System.Drawing.Point(464, 77);
            this.GameTypeIDComboBox.Name = "GameTypeIDComboBox";
            this.GameTypeIDComboBox.Size = new System.Drawing.Size(121, 21);
            this.GameTypeIDComboBox.TabIndex = 11;
            // 
            // LeagueIDComboBox
            // 
            this.LeagueIDComboBox.FormattingEnabled = true;
            this.LeagueIDComboBox.Location = new System.Drawing.Point(464, 37);
            this.LeagueIDComboBox.Name = "LeagueIDComboBox";
            this.LeagueIDComboBox.Size = new System.Drawing.Size(121, 21);
            this.LeagueIDComboBox.TabIndex = 12;
            // 
            // EventCancelButton
            // 
            this.EventCancelButton.Location = new System.Drawing.Point(384, 194);
            this.EventCancelButton.Name = "EventCancelButton";
            this.EventCancelButton.Size = new System.Drawing.Size(75, 23);
            this.EventCancelButton.TabIndex = 13;
            this.EventCancelButton.Text = "Izadji";
            this.EventCancelButton.UseVisualStyleBackColor = true;
            this.EventCancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ViewButton
            // 
            this.ViewButton.Location = new System.Drawing.Point(526, 228);
            this.ViewButton.Name = "ViewButton";
            this.ViewButton.Size = new System.Drawing.Size(75, 23);
            this.ViewButton.TabIndex = 14;
            this.ViewButton.Text = "Pogled";
            this.ViewButton.UseVisualStyleBackColor = true;
            this.ViewButton.Click += new System.EventHandler(this.ViewButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Vrijeme dogadjaja:";
            // 
            // EventDateTimePicker
            // 
            this.EventDateTimePicker.Location = new System.Drawing.Point(133, 162);
            this.EventDateTimePicker.Name = "EventDateTimePicker";
            this.EventDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.EventDateTimePicker.TabIndex = 16;
            this.EventDateTimePicker.Value = new System.DateTime(2017, 4, 30, 0, 0, 0, 0);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(100, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(394, 135);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // EventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 247);
            this.Controls.Add(this.EventDateTimePicker);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ViewButton);
            this.Controls.Add(this.EventCancelButton);
            this.Controls.Add(this.LeagueIDComboBox);
            this.Controls.Add(this.GameTypeIDComboBox);
            this.Controls.Add(this.TeamID1ComboBox);
            this.Controls.Add(this.TeamIDComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.QuotaTextBox);
            this.Controls.Add(this.SportIDComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.pictureBox1);
            this.Name = "EventForm";
            this.Text = "EventForma";
            this.Load += new System.EventHandler(this.EventForma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox SportIDComboBox;
        private System.Windows.Forms.TextBox QuotaTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox TeamIDComboBox;
        private System.Windows.Forms.ComboBox TeamID1ComboBox;
        private System.Windows.Forms.ComboBox GameTypeIDComboBox;
        private System.Windows.Forms.ComboBox LeagueIDComboBox;
        private System.Windows.Forms.Button EventCancelButton;
        private System.Windows.Forms.Button ViewButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker EventDateTimePicker;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}