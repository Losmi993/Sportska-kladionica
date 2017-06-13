using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KladionicaNova.Forme;
using KladionicaNova.Models;
using KladionicaNova.Properties;
using KladionicaNova.Repository;
using System.Data.SqlServerCe;

namespace KladionicaNova.View
{
    public partial class LeagueView : Form
    {
        public LeagueView()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void CancelViewButton_Click(object sender, EventArgs e)
        {
            Form newform = new LeagueForm();
            this.Hide();
            this.Close();
            newform.Show();
        }

        private void PopulateLeagueComboBox()
        {
            SqlCeConnection Connection = DataBaseConnection.Instance.Connection;


            LeagueViewComboBox.Items.Clear();
            SqlCeCommand cmd = Connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM League";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                LeagueViewComboBox.Items.Add(dr["NameLeague"].ToString());
            }
            LeagueViewComboBox.SelectedIndex = 0;
        }

        private void LeagueView_Load(object sender, EventArgs e)
        {
            PopulateLeagueComboBox();
        }

        private void DeleteLeagueButton_Click(object sender, EventArgs e)
        {
            SqlCeConnection Connection = DataBaseConnection.Instance.Connection;


            DialogResult dr = MessageBox.Show("Da li želite da izbrišete ?", "Brisanje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {

                string name = LeagueViewComboBox.SelectedItem.ToString();

                LeagueRepository.DeleteDataLeague(name);
                LeagueViewComboBox.Items.Remove(LeagueViewComboBox.SelectedItem);

            }

            else if (dr == DialogResult.No) { }
        }
    }
}
