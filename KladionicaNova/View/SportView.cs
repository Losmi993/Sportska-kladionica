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
    public partial class SportView : Form
    {
        public SportView()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Form newform = new GameTypeForm();
            this.Hide();
            this.Close();
            newform.Show();
        }

        private void PopulateSportComboBox()
        {
            SqlCeConnection Connection = DataBaseConnection.Instance.Connection;


            SportViewComboBox.Items.Clear();
            SqlCeCommand cmd = Connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Sport";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                SportViewComboBox.Items.Add(dr["NameSport"].ToString());
            }
            SportViewComboBox.SelectedIndex = 0;
        }

        private void SportView_Load(object sender, EventArgs e)
        {
            PopulateSportComboBox();
        }

        private void DeleteSportButton_Click(object sender, EventArgs e)
        {

            SqlCeConnection Connection = DataBaseConnection.Instance.Connection;


            DialogResult dr = MessageBox.Show("Da li želite da izbrišete ?", "Brisanje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {

                string name = SportViewComboBox.SelectedItem.ToString();
                
                SportRepository.DeleteDataSport(name);
                SportViewComboBox.Items.Remove(SportViewComboBox.SelectedItem);

            }

            else if (dr == DialogResult.No) { }
        }
    }
}
