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
using KladionicaNova.View;
using System.Data.SqlServerCe;

namespace KladionicaNova.Forme
{
    public partial class EventForm : Form
    {
        public EventForm()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Form newform = new PocetnaForma();
            this.Hide();
            this.Close();
            newform.Show();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SqlCeConnection Connection = DataBaseConnection.Instance.Connection;

            try
            {
                if (QuotaTextBox.Text == "")
                { MessageBox.Show("Uneste iznos kvote!"); }
                else if (EventDateTimePicker.Text == "")
                { MessageBox.Show("Unesite vrijeme dogadjaja!"); }

                else
                {
                    int SportID = SportRepository.GetIdByNameSport(SportIDComboBox.Text);
                    int TeamID = TeamRepository.GetIdByNameTeam(TeamIDComboBox.Text);
                    int LeagueID = LeagueRepository.GetIdByNameLeague(LeagueIDComboBox.Text);
                    int GameTypeID = GameTypeRepository.GetIdByNameGameType(GameTypeIDComboBox.Text);
                    int TeamID1 = TeamRepository.GetIdByNameTeam(TeamID1ComboBox.Text);


                    SqlCeCommand command1 = new SqlCeCommand("INSERT INTO Event (Sport_Id, Team_Id, Time, League_Id, Game_type_Id, Quota, Team_Id1) VALUES" + " ('" + SportID +"', '" + TeamID +"', '" + EventDateTimePicker.Value.Date.ToString("yyyy-MM-dd") + "', '" + LeagueID +"', '" + GameTypeID + "',  '" + QuotaTextBox.Text + "',  '" + TeamID1 + "'); ", Connection);
                    

                    /*SqlCeCommand command1 = new SqlCeCommand(@"INSERT INTO Event (Sport_Id, Team_Id, Time, League_Id, Game_type_Id, Quota, Team_Id1) VALUES (@sportId, @teamId, @time, @leagueId, @gameTypeId, @quota, @teamId1)", Connection);
                    command1.Parameters.AddWithValue("@sportId", SportID);
                    command1.Parameters.AddWithValue("@teamId", TeamID);
                    command1.Parameters.AddWithValue("@time", DateTime.Now.Date.ToString());
                    command1.Parameters.AddWithValue("@leagueId", LeagueID);
                    command1.Parameters.AddWithValue("@gameTypeId", GameTypeID);
                    command1.Parameters.AddWithValue("@quota", QuotaTextBox.Text);
                    command1.Parameters.AddWithValue("@teamId1", TeamID1);*/


                    command1.ExecuteNonQuery();
                    MessageBox.Show("Unos je uspio!");
                    QuotaTextBox.Clear();
                    QuotaTextBox.Focus();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Unos nije uspio! \r Greska: " + ex.Message);
                return;
            }

        }
        private void PopulateSportComboBox()
        {
            SqlCeConnection Connection = DataBaseConnection.Instance.Connection;


            SportIDComboBox.Items.Clear();
            SqlCeCommand cmd = Connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Sport";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                SportIDComboBox.Items.Add(dr["NameSport"].ToString());
            }
            SportIDComboBox.SelectedIndex = 0;
        }
        private void PopulateTeamComboBox()
        {
            SqlCeConnection Connection = DataBaseConnection.Instance.Connection;


            TeamIDComboBox.Items.Clear();
            SqlCeCommand cmd = Connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Team";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                TeamIDComboBox.Items.Add(dr["Name"].ToString());
            }
            TeamIDComboBox.SelectedIndex = 0;
        }

        private void PopulateLeagueComboBox()
        {
            SqlCeConnection Connection = DataBaseConnection.Instance.Connection;


            LeagueIDComboBox.Items.Clear();
            SqlCeCommand cmd = Connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM League";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                LeagueIDComboBox.Items.Add(dr["NameLeague"].ToString());
            }
            LeagueIDComboBox.SelectedIndex = 0;
        }
        private void PopulateGameTypeComboBox()
        {
            SqlCeConnection Connection = DataBaseConnection.Instance.Connection;


            GameTypeIDComboBox.Items.Clear();
            SqlCeCommand cmd = Connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Game_type";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                GameTypeIDComboBox.Items.Add(dr["Mark"].ToString());
            }
            GameTypeIDComboBox.SelectedIndex = 0;
        }
        

        private void PopulateTeam1ComboBox()
        {
            SqlCeConnection Connection = DataBaseConnection.Instance.Connection;


            TeamID1ComboBox.Items.Clear();
            SqlCeCommand cmd = Connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Team";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                TeamID1ComboBox.Items.Add(dr["Name"].ToString());
            }
            TeamID1ComboBox.SelectedIndex = 0;
        }

        private void EventForma_Load(object sender, EventArgs e)
        {
            PopulateSportComboBox();
            PopulateTeamComboBox();
            PopulateLeagueComboBox();
            PopulateGameTypeComboBox();
            PopulateTeam1ComboBox();
            EventDateTimePicker.CustomFormat = "yyyy-MM-dd";
            
        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            Form newform = new EventView();
            this.Hide();
            this.Close();
            newform.Show();
        }
    }
}
