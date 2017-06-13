using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlServerCe;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KladionicaNova.Forme;
using KladionicaNova.Models;
using KladionicaNova.Properties;
using KladionicaNova.Repository;
using KladionicaNova.View;


namespace KladionicaNova.Forme
{
    public partial class GameTypeForm : Form
    {
        public GameTypeForm()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void MarkTextBox_TextChanged(object sender, EventArgs e) { }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (MarkTextBox.Text == "")
            { MessageBox.Show("Unesite vrstu igre!"); }

            else
            {
                string text = MarkTextBox.Text;
                GameTypeRepository.AddGameType(text);
            }
            
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Form newform = new PocetnaForma();
            this.Hide();
            this.Close();
            newform.Show();
        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            Form newform = new GameTypeView();
            this.Hide();
            this.Close();
            newform.Show();
        }

        private void GameTypeForm_Load(object sender, EventArgs e)
        {
        }
    }
}
