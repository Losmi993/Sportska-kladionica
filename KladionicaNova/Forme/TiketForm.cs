using KladionicaNova.Repository;
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

namespace KladionicaNova.Forme
{
    public partial class TiketForm : Form
    {
        private const string FILE_PATH = @".\ticket.txt";


        public TiketForm()
        {
            InitializeComponent();
            CenterToParent();
        }

        private void TiketForm_Load(object sender, EventArgs e)
        {
            PopulateEventComboBox();
            TicketDataRepository.DeleteData();

        }
        private void PopulateTiketListView()
        {
            List<String> a = TicketDataRepository.Text;
            listBox.Items.Clear();
            listBox.Items.AddRange(a.ToArray());
        }
        private void PopulateEventComboBox()
        {
            SqlCeConnection Connection = DataBaseConnection.Instance.Connection;

            EventComboBox.Items.Clear();
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

                string team11 = TeamRepository.GetTeamNameById(team1);
                string team22 = TeamRepository.GetTeamNameById(team2);
                string game11 = GameTypeRepository.GetGameTypeMarkById(game1);

                EventComboBox.Items.Add(team11 + " - " + team22 + " - " + dr["Time"].ToString() + " - " + game11 + " - " + dr["Quota"].ToString() + "KM ");
            }
            EventComboBox.SelectedIndex = 0;
        }

        private void EventComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private string CurrentItemSelected()
        {
            return EventComboBox.Text;
        }

        private void AddEventButton_Click(object sender, EventArgs e)
        {
            string text = CurrentItemSelected();
            TicketDataRepository.AddData(text);
            PopulateTiketListView();
            listBox.SelectedIndex = 0;
        }

        private void TicketCancelButton_Click(object sender, EventArgs e)
        {
            Form newform = new PocetnaForma();
            this.Hide();
            this.Close();
            newform.Show();
        }
     
        private void SaveTicketButton_Click(object sender, EventArgs e)
        {
            string text = listBox.Text;
            int id = TicketDataRepository.GetIdByTicketDataText(text);
            TicketRepository.AddTicket(DateTime.Now, id);

        }
    }
}
