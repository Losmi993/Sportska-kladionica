namespace KladionicaNova.View
{
    partial class LeagueView
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
            this.LeagueViewComboBox = new System.Windows.Forms.ComboBox();
            this.CancelLeagueViewButton = new System.Windows.Forms.Button();
            this.DeleteLeagueButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LeagueViewComboBox
            // 
            this.LeagueViewComboBox.FormattingEnabled = true;
            this.LeagueViewComboBox.Location = new System.Drawing.Point(81, 71);
            this.LeagueViewComboBox.Name = "LeagueViewComboBox";
            this.LeagueViewComboBox.Size = new System.Drawing.Size(121, 21);
            this.LeagueViewComboBox.TabIndex = 0;
            // 
            // CancelLeagueViewButton
            // 
            this.CancelLeagueViewButton.Location = new System.Drawing.Point(162, 183);
            this.CancelLeagueViewButton.Name = "CancelLeagueViewButton";
            this.CancelLeagueViewButton.Size = new System.Drawing.Size(75, 23);
            this.CancelLeagueViewButton.TabIndex = 1;
            this.CancelLeagueViewButton.Text = "Izadji";
            this.CancelLeagueViewButton.UseVisualStyleBackColor = true;
            this.CancelLeagueViewButton.Click += new System.EventHandler(this.CancelViewButton_Click);
            // 
            // DeleteLeagueButton
            // 
            this.DeleteLeagueButton.Location = new System.Drawing.Point(29, 183);
            this.DeleteLeagueButton.Name = "DeleteLeagueButton";
            this.DeleteLeagueButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteLeagueButton.TabIndex = 2;
            this.DeleteLeagueButton.Text = "Izbrisi";
            this.DeleteLeagueButton.UseVisualStyleBackColor = true;
            this.DeleteLeagueButton.Click += new System.EventHandler(this.DeleteLeagueButton_Click);
            // 
            // LeagueView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.DeleteLeagueButton);
            this.Controls.Add(this.CancelLeagueViewButton);
            this.Controls.Add(this.LeagueViewComboBox);
            this.Name = "LeagueView";
            this.Text = "LeagueView";
            this.Load += new System.EventHandler(this.LeagueView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox LeagueViewComboBox;
        private System.Windows.Forms.Button CancelLeagueViewButton;
        private System.Windows.Forms.Button DeleteLeagueButton;
    }
}