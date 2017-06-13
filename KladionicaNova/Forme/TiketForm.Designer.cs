namespace KladionicaNova.Forme
{
    partial class TiketForm
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
            this.AddEventButton = new System.Windows.Forms.Button();
            this.EventComboBox = new System.Windows.Forms.ComboBox();
            this.listBox = new System.Windows.Forms.ListBox();
            this.TicketCancelButton = new System.Windows.Forms.Button();
            this.SaveTicketButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddEventButton
            // 
            this.AddEventButton.Location = new System.Drawing.Point(154, 39);
            this.AddEventButton.Name = "AddEventButton";
            this.AddEventButton.Size = new System.Drawing.Size(75, 23);
            this.AddEventButton.TabIndex = 0;
            this.AddEventButton.Text = "Dodaj";
            this.AddEventButton.UseVisualStyleBackColor = true;
            this.AddEventButton.Click += new System.EventHandler(this.AddEventButton_Click);
            // 
            // EventComboBox
            // 
            this.EventComboBox.FormattingEnabled = true;
            this.EventComboBox.Location = new System.Drawing.Point(24, 12);
            this.EventComboBox.Name = "EventComboBox";
            this.EventComboBox.Size = new System.Drawing.Size(322, 21);
            this.EventComboBox.TabIndex = 4;
            this.EventComboBox.SelectedIndexChanged += new System.EventHandler(this.EventComboBox_SelectedIndexChanged);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(24, 79);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(322, 225);
            this.listBox.TabIndex = 5;
            // 
            // TicketCancelButton
            // 
            this.TicketCancelButton.Location = new System.Drawing.Point(271, 319);
            this.TicketCancelButton.Name = "TicketCancelButton";
            this.TicketCancelButton.Size = new System.Drawing.Size(75, 23);
            this.TicketCancelButton.TabIndex = 8;
            this.TicketCancelButton.Text = "Izadji";
            this.TicketCancelButton.UseVisualStyleBackColor = true;
            this.TicketCancelButton.Click += new System.EventHandler(this.TicketCancelButton_Click);
            // 
            // SaveTicketButton
            // 
            this.SaveTicketButton.Location = new System.Drawing.Point(36, 319);
            this.SaveTicketButton.Name = "SaveTicketButton";
            this.SaveTicketButton.Size = new System.Drawing.Size(75, 23);
            this.SaveTicketButton.TabIndex = 9;
            this.SaveTicketButton.Text = "Sacuvaj";
            this.SaveTicketButton.UseVisualStyleBackColor = true;
            this.SaveTicketButton.Click += new System.EventHandler(this.SaveTicketButton_Click);
            // 
            // TiketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 344);
            this.Controls.Add(this.SaveTicketButton);
            this.Controls.Add(this.TicketCancelButton);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.EventComboBox);
            this.Controls.Add(this.AddEventButton);
            this.Name = "TiketForm";
            this.Text = "TiketForm";
            this.Load += new System.EventHandler(this.TiketForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddEventButton;
        private System.Windows.Forms.ComboBox EventComboBox;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button TicketCancelButton;
        private System.Windows.Forms.Button SaveTicketButton;
    }
}