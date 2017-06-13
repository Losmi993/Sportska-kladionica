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
    public partial class TeamForm : Form
    {
        public TeamForm()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void TeamForm_Load(object sender, EventArgs e)
        {
            
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (NameTeamTextBox.Text == "")
            { MessageBox.Show("Unesite ime tima!!!"); }

            else
            {
                string text = NameTeamTextBox.Text;
                TeamRepository.AddTeam(text);
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
            Form newform = new TeamView();
            this.Hide();
            this.Close();
            newform.Show();
        }

        
    }
}
