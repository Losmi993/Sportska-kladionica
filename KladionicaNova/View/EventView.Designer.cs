namespace KladionicaNova.View
{
    partial class EventView
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
            this.EventViewComboBox = new System.Windows.Forms.ComboBox();
            this.CancelEventViewButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EventViewComboBox
            // 
            this.EventViewComboBox.FormattingEnabled = true;
            this.EventViewComboBox.Location = new System.Drawing.Point(12, 58);
            this.EventViewComboBox.Name = "EventViewComboBox";
            this.EventViewComboBox.Size = new System.Drawing.Size(441, 21);
            this.EventViewComboBox.TabIndex = 0;
            // 
            // CancelEventViewButton
            // 
            this.CancelEventViewButton.Location = new System.Drawing.Point(207, 106);
            this.CancelEventViewButton.Name = "CancelEventViewButton";
            this.CancelEventViewButton.Size = new System.Drawing.Size(75, 23);
            this.CancelEventViewButton.TabIndex = 1;
            this.CancelEventViewButton.Text = "Izadji";
            this.CancelEventViewButton.UseVisualStyleBackColor = true;
            this.CancelEventViewButton.Click += new System.EventHandler(this.CancelEventButton_Click);
            // 
            // EventView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 147);
            this.Controls.Add(this.CancelEventViewButton);
            this.Controls.Add(this.EventViewComboBox);
            this.Name = "EventView";
            this.Text = "EventView";
            this.Load += new System.EventHandler(this.EventView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox EventViewComboBox;
        private System.Windows.Forms.Button CancelEventViewButton;
    }
}