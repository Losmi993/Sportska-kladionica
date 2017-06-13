using System;
using System.Collections.Generic;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KladionicaNova.Repository
{
    class LeagueRepository
    {
        public static void DeleteLeague()
        {
            SqlCeConnection Connection = DataBaseConnection.Instance.Connection;

            SqlCeCommand command = new SqlCeCommand(@"DELETE FROM League", Connection);
            command.ExecuteNonQuery();
        }

        public static void DeleteDataLeague(string name)
        {
            SqlCeConnection Connection = DataBaseConnection.Instance.Connection;

            SqlCeCommand command = new SqlCeCommand(@"DELETE FROM League WHERE NameLeague = @name", Connection);
            command.Parameters.AddWithValue("@name", name);
            command.ExecuteNonQuery();
        }

        public static string GetLeagueNameById(int i)
        {
            SqlCeConnection Connection = DataBaseConnection.Instance.Connection;

            SqlCeCommand command = new SqlCeCommand(@"SELECT NameLeague FROM League WHERE Id = @id", Connection);
            command.Parameters.AddWithValue("@id", i);
            SqlCeDataReader reader = command.ExecuteReader();

            reader.Read();

            string result = reader["NameLeague"].ToString();
            reader.Close();

            return result;
        }


        public static int GetIdByNameLeague(string name)
        {
            SqlCeConnection Connection = DataBaseConnection.Instance.Connection;

            SqlCeCommand command = new SqlCeCommand(@"SELECT Id FROM League WHERE NameLeague = @nameLeague", Connection);
            command.Parameters.AddWithValue("@nameLeague", name);
            SqlCeDataReader reader = command.ExecuteReader();

            reader.Read();

            int result = (int)reader["Id"];
            reader.Close();

            return result;
        }

        public static string GetNameLeagueQuery()
        {
            string query;
            query = @"SELECT NameLeague FROM League";
            return query;
        }

        public static bool AddLeague(string NameLeague)
        {
            SqlCeConnection Connection = DataBaseConnection.Instance.Connection;

            bool flag = false;

            try
            {

                SqlCeCommand command1 = new SqlCeCommand(@"INSERT INTO League (NameLeague) VALUES (@nameLeague)", Connection);
                command1.Parameters.AddWithValue("@nameLeague", NameLeague);

                int result = command1.ExecuteNonQuery();

                if (result > 0)
                {
                    flag = true;
                    MessageBox.Show("Uspjesno ste dodali vrstu lige!!!");
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
