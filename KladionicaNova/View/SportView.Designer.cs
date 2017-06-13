namespace KladionicaNova.View
{
    partial class SportView
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
            this.CancelSportViewButton = new System.Windows.Forms.Button();
            this.SportViewComboBox = new System.Windows.Forms.ComboBox();
            this.DeleteSportButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CancelSportViewButton
            // 
            this.CancelSportViewButton.Location = new System.Drawing.Point(154, 189);
            this.CancelSportViewButton.Name = "CancelSportViewButton";
            this.CancelSportViewButton.Size = new System.Drawing.Size(75, 23);
            this.CancelSportViewButton.TabIndex = 0;
            this.CancelSportViewButton.Text = "Izadji";
            this.CancelSportViewButton.UseVisualStyleBackColor = true;
            this.CancelSportViewButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SportViewComboBox
            // 
            this.SportViewComboBox.FormattingEnabled = true;
            this.SportViewComboBox.Location = new System.Drawing.Point(72, 78);
            this.SportViewComboBox.Name = "SportViewComboBox";
            this.SportViewComboBox.Size = new System.Drawing.Size(121, 21);
            this.SportViewComboBox.TabIndex = 1;
            // 
            // DeleteSportButton
            // 
            this.DeleteSportButton.Location = new System.Drawing.Point(31, 189);
            this.DeleteSportButton.Name = "DeleteSportButton";
            this.DeleteSportButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteSportButton.TabIndex = 2;
            this.DeleteSportButton.Text = "Izbrisi";
            this.DeleteSportButton.UseVisualStyleBackColor = true;
            this.DeleteSportButton.Click += new System.EventHandler(this.DeleteSportButton_Click);
            // 
            // SportView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.DeleteSportButton);
            this.Controls.Add(this.SportViewComboBox);
            this.Controls.Add(this.CancelSportViewButton);
            this.Name = "SportView";
            this.Text = "SportView";
            this.Load += new System.EventHandler(this.SportView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CancelSportViewButton;
        private System.Windows.Forms.ComboBox SportViewComboBox;
        private System.Windows.Forms.Button DeleteSportButton;
    }
}