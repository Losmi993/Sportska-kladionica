using System;
using System.Collections.Generic;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KladionicaNova.Repository
{
    class SportRepository
    {
        public static void DeleteSport()
        {
            SqlCeConnection Connection = DataBaseConnection.Instance.Connection;

            SqlCeCommand command = new SqlCeCommand(@"DELETE FROM Sport", Connection);
            command.ExecuteNonQuery();
        }

        public static void DeleteDataSport(string name)
        {
            SqlCeConnection Connection = DataBaseConnection.Instance.Connection;

            SqlCeCommand command = new SqlCeCommand(@"DELETE FROM Sport WHERE NameSport = @name", Connection);
            command.Parameters.AddWithValue("@name", name);
            command.ExecuteNonQuery();
        }

        public static string GetSportNameById(int i)
        {
            SqlCeConnection Connection = DataBaseConnection.Instance.Connection;

            SqlCeCommand command = new SqlCeCommand(@"SELECT NameSport FROM Sport WHERE Id = @id", Connection);
            command.Parameters.AddWithValue("@id", i);
            SqlCeDataReader reader = command.ExecuteReader();

            reader.Read();

            string result = reader["NameSport"].ToString();
            reader.Close();

            return result;
        }



        public static int GetIdByNameSport(string name)
        {
            SqlCeConnection Connection = DataBaseConnection.Instance.Connection;

            SqlCeCommand command = new SqlCeCommand(@"SELECT Id FROM Sport WHERE NameSport = @nameSport", Connection);
            command.Parameters.AddWithValue("@nameSport", name);
            SqlCeDataReader reader = command.ExecuteReader();

            reader.Read();

            int result = (int)reader["Id"];
            reader.Close();

            return result;
        }

       

        public static string GetNameSportQuery()
        {

            string query;
            query = @"SELECT NameSport FROM Sport";
            return query;
        }

        public static bool AddSport(string NameSport)
        {
            SqlCeConnection Connection = DataBaseConnection.Instance.Connection;

            bool flag = false;

            try
            {

                SqlCeCommand command1 = new SqlCeCommand(@"INSERT INTO Sport (NameSport) VALUES (@nameSport)", Connection);
                command1.Parameters.AddWithValue("@nameSport", NameSport);

                int result = command1.ExecuteNonQuery();

                if (result > 0)
                {
                    flag = true;
                    MessageBox.Show("Uspjesno ste dodali sport!!!");
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
