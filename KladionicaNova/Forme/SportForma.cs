using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KladionicaNova.Models;
using KladionicaNova.Properties;
using KladionicaNova.Repository;
using KladionicaNova.View;
using System.Data.SqlServerCe;

namespace KladionicaNova.Forme
{
    public partial class SportForma : Form
    {
        public SportForma()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void SportForma_Load(object sender, EventArgs e)
        {
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (NameSportTextBox.Text == "")
            { MessageBox.Show("Unesite vrstu sport!!!"); }
            else
            {
                string text = NameSportTextBox.Text;
                SportRepository.AddSport(text);
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
            Form newform = new SportView();
            this.Hide();
            this.Close();
            newform.Show();
        }
    }
}
