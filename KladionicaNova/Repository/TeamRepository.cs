using System;
using System.Collections.Generic;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KladionicaNova.Repository
{
    class TeamRepository
    {
        public static void DeleteTeam()
        {
            SqlCeConnection Connection = DataBaseConnection.Instance.Connection;

            SqlCeCommand command = new SqlCeCommand(@"DELETE FROM Team", Connection);
            command.ExecuteNonQuery();
        }
        public static void DeleteDataTeam(string name)
        {
            SqlCeConnection Connection = DataBaseConnection.Instance.Connection;

            SqlCeCommand command = new SqlCeCommand(@"DELETE FROM Team WHERE Name = @name", Connection);
            command.Parameters.AddWithValue("@name", name);
            command.ExecuteNonQuery();
        }


        public static int GetIdByNameTeam(string name)
        {
            SqlCeConnection Connection = DataBaseConnection.Instance.Connection;

            SqlCeCommand command = new SqlCeCommand(@"SELECT Id FROM Team WHERE Name = @name", Connection);
            command.Parameters.AddWithValue("@name", name);
            SqlCeDataReader reader = command.ExecuteReader();

            reader.Read();

            int result = (int)reader["Id"];
            reader.Close();

            return result;
        }
        public static string GetTeamNameById(int i)
        {
            SqlCeConnection Connection = DataBaseConnection.Instance.Connection;

            SqlCeCommand command = new SqlCeCommand(@"SELECT Name FROM Team WHERE Id = @id", Connection);
            command.Parameters.AddWithValue("@id", i);
            SqlCeDataReader reader = command.ExecuteReader();

            reader.Read();

            string result = reader["Name"].ToString();
            reader.Close();

            return result;
        }

        public static string GetNameTeamQuery()
        {

            string query;
            query = @"SELECT Name FROM Team ";
            return query;
        }

        public static bool AddTeam(string Name)
        {
            SqlCeConnection Connection = DataBaseConnection.Instance.Connection;

            bool flag = false;

            try
            {

                SqlCeCommand command1 = new SqlCeCommand(@"INSERT INTO Team (Name) VALUES (@name)", Connection);
                command1.Parameters.AddWithValue("@name", Name);

                int result = command1.ExecuteNonQuery();

                if (result > 0)
                {
                    flag = true;
                    MessageBox.Show("Uspjesno ste dodali tim!!!");
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
