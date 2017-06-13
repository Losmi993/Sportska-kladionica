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
using System.Data.SqlServerCe;
using KladionicaNova.Repository;

namespace KladionicaNova.View
{
    public partial class EventView : Form
    {
        public EventView()
        {
            InitializeComponent();
            CenterToParent();
        }

        private void CancelEventButton_Click(object sender, EventArgs e)
        {
            Form newform = new EventForm();
            this.Hide();
            this.Close();
            newform.Show();
        }
        
        private void PopulateEventComboBox()
        {
            SqlCeConnection Connection = DataBaseConnection.Instance.Connection;


            EventViewComboBox.Items.Clear();
            SqlCeCommand cmd = Connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Event";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                int team1 = Int16.Parse(dr["Team_Id"].ToString());
                int team2 = Int16.Parse(dr["Team_Id1"].ToString());
                int game1 = Int16.Parse(dr["Game_type_Id"].ToString());
                int sport1 = Int16.Parse(dr["Sport_Id"].ToString());
                int leage1 = Int16.Parse(dr["League_Id"].ToString());

                string team11 = TeamRepository.GetTeamNameById(team1);
                string team22 = TeamRepository.GetTeamNameById(team2);
                string game11 = GameTypeRepository.GetGameTypeMarkById(game1);
                string sport11 = SportRepository.GetSportNameById(sport1);
                string league11 = LeagueRepository.GetLeagueNameById(leage1);

                EventViewComboBox.Items.Add(sport11 + " - " + league11 + " - " + team11 + " - " + team22 + " - " + dr["Time"].ToString() + " - " + game11 + " - " + dr["Quota"].ToString() + "KM ");
            }
            EventViewComboBox.SelectedIndex = 0;
        }

        private void EventView_Load(object sender, EventArgs e)
        {
            PopulateEventComboBox();
        }
    }
}
