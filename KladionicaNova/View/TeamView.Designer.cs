namespace KladionicaNova.View
{
    partial class TeamView
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
            this.TeamViewComboBox = new System.Windows.Forms.ComboBox();
            this.CancelTeamViewButton = new System.Windows.Forms.Button();
            this.DeleteTeamButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TeamViewComboBox
            // 
            this.TeamViewComboBox.FormattingEnabled = true;
            this.TeamViewComboBox.Location = new System.Drawing.Point(75, 69);
            this.TeamViewComboBox.Name = "TeamViewComboBox";
            this.TeamViewComboBox.Size = new System.Drawing.Size(121, 21);
            this.TeamViewComboBox.TabIndex = 0;
            // 
            // CancelTeamViewButton
            // 
            this.CancelTeamViewButton.Location = new System.Drawing.Point(174, 185);
            this.CancelTeamViewButton.Name = "CancelTeamViewButton";
            this.CancelTeamViewButton.Size = new System.Drawing.Size(75, 23);
            this.CancelTeamViewButton.TabIndex = 1;
            this.CancelTeamViewButton.Text = "Izadji";
            this.CancelTeamViewButton.UseVisualStyleBackColor = true;
            this.CancelTeamViewButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // DeleteTeamButton
            // 
            this.DeleteTeamButton.Location = new System.Drawing.Point(28, 185);
            this.DeleteTeamButton.Name = "DeleteTeamButton";
            this.DeleteTeamButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteTeamButton.TabIndex = 2;
            this.DeleteTeamButton.Text = "Izbrisi";
            this.DeleteTeamButton.UseVisualStyleBackColor = true;
            this.DeleteTeamButton.Click += new System.EventHandler(this.DeleteTeamButton_Click);
            // 
            // TeamView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.DeleteTeamButton);
            this.Controls.Add(this.CancelTeamViewButton);
            this.Controls.Add(this.TeamViewComboBox);
            this.Name = "TeamView";
            this.Text = "TeamView";
            this.Load += new System.EventHandler(this.TeamView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox TeamViewComboBox;
        private System.Windows.Forms.Button CancelTeamViewButton;
        private System.Windows.Forms.Button DeleteTeamButton;
    }
}