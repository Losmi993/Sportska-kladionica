namespace KladionicaNova.View
{
    partial class GameTypeView
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
            this.GameTypeViewComboBox = new System.Windows.Forms.ComboBox();
            this.CancelViewGameTypeButton = new System.Windows.Forms.Button();
            this.DeleteGameTypeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GameTypeViewComboBox
            // 
            this.GameTypeViewComboBox.FormattingEnabled = true;
            this.GameTypeViewComboBox.Location = new System.Drawing.Point(72, 63);
            this.GameTypeViewComboBox.Name = "GameTypeViewComboBox";
            this.GameTypeViewComboBox.Size = new System.Drawing.Size(121, 21);
            this.GameTypeViewComboBox.TabIndex = 0;
            // 
            // CancelViewGameTypeButton
            // 
            this.CancelViewGameTypeButton.Location = new System.Drawing.Point(170, 164);
            this.CancelViewGameTypeButton.Name = "CancelViewGameTypeButton";
            this.CancelViewGameTypeButton.Size = new System.Drawing.Size(75, 23);
            this.CancelViewGameTypeButton.TabIndex = 1;
            this.CancelViewGameTypeButton.Text = "Izadji";
            this.CancelViewGameTypeButton.UseVisualStyleBackColor = true;
            this.CancelViewGameTypeButton.Click += new System.EventHandler(this.CancelViewGameTypeButton_Click);
            // 
            // DeleteGameTypeButton
            // 
            this.DeleteGameTypeButton.Location = new System.Drawing.Point(31, 164);
            this.DeleteGameTypeButton.Name = "DeleteGameTypeButton";
            this.DeleteGameTypeButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteGameTypeButton.TabIndex = 2;
            this.DeleteGameTypeButton.Text = "Izbrisi";
            this.DeleteGameTypeButton.UseVisualStyleBackColor = true;
            this.DeleteGameTypeButton.Click += new System.EventHandler(this.DeleteGameTypeButton_Click);
            // 
            // GameTypeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 206);
            this.Controls.Add(this.DeleteGameTypeButton);
            this.Controls.Add(this.CancelViewGameTypeButton);
            this.Controls.Add(this.GameTypeViewComboBox);
            this.Name = "GameTypeView";
            this.Text = "GameTypeView";
            this.Load += new System.EventHandler(this.GameTypeView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox GameTypeViewComboBox;
        private System.Windows.Forms.Button CancelViewGameTypeButton;
        private System.Windows.Forms.Button DeleteGameTypeButton;
    }
}