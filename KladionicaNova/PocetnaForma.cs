using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlServerCe;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KladionicaNova.Forme;


namespace KladionicaNova
{
    public partial class PocetnaForma : Form
    {
        public PocetnaForma()
        {
            InitializeComponent();
            CenterToScreen();
        }
        string home = Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory().ToString()).ToString()).ToString();

        public string GetHomeDirectory()
        {
            return home;
        }

        private void PocetnaForma_Load(object sender, EventArgs e)
        {
            SqlCeConnection Connection = DataBaseConnection.Instance.Connection;

        }

        private void tiketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form newform = new TiketForm();
            this.Hide();
            newform.Show();
        }

        private void dogadjajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form newform = new EventForm();
            this.Hide();
            newform.Show();
        }

        private void timToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form newform = new TeamForm();
            this.Hide();
            newform.Show();
        }

        private void sportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form newform = new SportForma();
            this.Hide();
            newform.Show();
        }

        private void ligaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form newform = new LeagueForm();
            this.Hide();
            newform.Show();
        }

        private void tipIgreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form newform = new GameTypeForm();
            this.Hide();
            newform.Show();
        }
    }
}
