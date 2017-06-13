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
    public partial class GameTypeView : Form
    {
        public GameTypeView()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void GameTypeView_Load(object sender, EventArgs e)
        {
            PopulateGameTypeComboBox();
        }

        private void CancelViewGameTypeButton_Click(object sender, EventArgs e)
        {
            Form newform = new GameTypeForm();
            this.Hide();
            this.Close();
            newform.Show();
        }

        private void PopulateGameTypeComboBox()
        {
            SqlCeConnection Connection = DataBaseConnection.Instance.Connection;


            GameTypeViewComboBox.Items.Clear();
            SqlCeCommand cmd = Connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Game_type";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                GameTypeViewComboBox.Items.Add(dr["Mark"].ToString());
            }
            GameTypeViewComboBox.SelectedIndex = 0;
        }

        private void DeleteGameTypeButton_Click(object sender, EventArgs e)
        {
            SqlCeConnection Connection = DataBaseConnection.Instance.Connection;


            DialogResult dr = MessageBox.Show("Da li želite da izbrišete ?", "Brisanje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {

                string name = GameTypeViewComboBox.SelectedItem.ToString();

                GameTypeRepository.DeleteDataGameType(name);
                GameTypeViewComboBox.Items.Remove(GameTypeViewComboBox.SelectedItem);

            }

            else if (dr == DialogResult.No) { }
        }
    }
}
