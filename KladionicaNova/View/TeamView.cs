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
using System.Data.SqlServerCe;
using KladionicaNova.Forme;

namespace KladionicaNova.View
{
    public partial class TeamView : Form
    {
        public TeamView()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void TeamView_Load(object sender, EventArgs e)
        {
            PopulateTeamComboBox();
        }

        private void PopulateTeamComboBox()
        {
            SqlCeConnection Connection = DataBaseConnection.Instance.Connection;
            
            TeamViewComboBox.Items.Clear();
            SqlCeCommand cmd = Connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Team";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                TeamViewComboBox.Items.Add(dr["Name"].ToString());
            }
            TeamViewComboBox.SelectedIndex = 0;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Form newform = new TeamForm();
            this.Hide();
            this.Close();
            newform.Show();
        }
        private static SqlCeConnection connection = DataBaseConnection.Instance.Connection;


        private void DeleteTeamButton_Click(object sender, EventArgs e)
        {
            
            SqlCeConnection Connection = DataBaseConnection.Instance.Connection;
            
            DialogResult dr = MessageBox.Show("Da li želite da izbrišete ?", "Brisanje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
             {

                 string name = TeamViewComboBox.SelectedItem.ToString();

                TeamRepository.DeleteDataTeam(name);
                TeamViewComboBox.Items.Remove(TeamViewComboBox.SelectedItem);
               
             }

             else if (dr == DialogResult.No) { }
        }
    }
}
