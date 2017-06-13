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
using KladionicaNova.Models;
using KladionicaNova.Properties;
using KladionicaNova.Repository;
using KladionicaNova.View;


namespace KladionicaNova.Forme
{
    public partial class LeagueForm : Form
    {
        public LeagueForm()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void LeagueForm_Load(object sender, EventArgs e)
        {
            
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (NameLeagueTextBox.Text == "")
            { MessageBox.Show("Unesite vrstu lige!"); }

            else
            {
                string text = NameLeagueTextBox.Text;
                LeagueRepository.AddLeague(text);
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
            Form newform = new LeagueView();
            this.Hide();
            this.Close();
            newform.Show();
        }
    }
}
