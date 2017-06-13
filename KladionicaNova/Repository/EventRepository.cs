using System;
using System.Collections.Generic;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KladionicaNova.Repository
{
    class EventRepository
    {
        public static string GetQuotaQuery()
        {

            string query;
            query = @"SELECT Quota FROM Event";
            return query;
        }
        

        public static bool AddEvent(string Sport_Id, string Team_Id, DateTime Time, string League_Id, string Game_type_Id, float Quota, string Team_Id1)
        {
            SqlCeConnection Connection = DataBaseConnection.Instance.Connection;

            bool flag = false;

            try
            {
                

                SqlCeCommand command1 = new SqlCeCommand(@"INSERT INTO Event (Sport_Id, Team_Id, Time, League_Id, Game_type_Id, Qouta, Team_Id1) VALUES (@sportId, @teamId, @time, @leagueId, @gameTypeId, @qouta, @teamId1)", Connection);
                command1.Parameters.AddWithValue("@sportId", Sport_Id);
                command1.Parameters.AddWithValue("@teamId", Team_Id);
                command1.Parameters.AddWithValue("@time", Time);
                command1.Parameters.AddWithValue("@leagueId", League_Id);
                command1.Parameters.AddWithValue("@gameTypeId", Game_type_Id);
                command1.Parameters.AddWithValue("@qouta", Quota);
                command1.Parameters.AddWithValue("@teamId1", Team_Id1);

                int result = command1.ExecuteNonQuery();

                if (result > 0)
                {
                    flag = true;
                    MessageBox.Show("Uspjesno ste dodali dogadjaj!!!");
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return flag;
        }
    }
}
