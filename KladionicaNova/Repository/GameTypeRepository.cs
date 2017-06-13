using System;
using System.Collections.Generic;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KladionicaNova.Repository
{
    class GameTypeRepository
    {
        public static void DeleteGameType()
        {
            SqlCeConnection Connection = DataBaseConnection.Instance.Connection;

            SqlCeCommand command = new SqlCeCommand(@"DELETE FROM Game_type", Connection);
            command.ExecuteNonQuery();
        }

        public static void DeleteDataGameType(string name)
        {
            SqlCeConnection Connection = DataBaseConnection.Instance.Connection;

            SqlCeCommand command = new SqlCeCommand(@"DELETE FROM Game_type WHERE Mark = @name", Connection);
            command.Parameters.AddWithValue("@name", name);
            command.ExecuteNonQuery();
        }

        public static string GetGameTypeMarkById(int i)
        {
            SqlCeConnection Connection = DataBaseConnection.Instance.Connection;

            SqlCeCommand command = new SqlCeCommand(@"SELECT Mark FROM Game_Type WHERE Id = @id", Connection);
            command.Parameters.AddWithValue("@id", i);
            SqlCeDataReader reader = command.ExecuteReader();

            reader.Read();

            string result = reader["Mark"].ToString();
            reader.Close();

            return result;
        }


        public static int GetIdByNameGameType(string name)
        {
            SqlCeConnection Connection = DataBaseConnection.Instance.Connection;

            SqlCeCommand command = new SqlCeCommand(@"SELECT Id FROM Game_type WHERE Mark = @mark", Connection);
            command.Parameters.AddWithValue("@mark", name);
            SqlCeDataReader reader = command.ExecuteReader();

            reader.Read();

            int result = (int)reader["Id"];
            reader.Close();
            return result;
        }

        public static string GetMarkQuery()
        {
            string query;
            query = @"SELECT Mark FROM  Game_type";
            return query;
        }

        public static bool AddGameType(string Mark)
        {
            SqlCeConnection Connection = DataBaseConnection.Instance.Connection;

            bool flag = false;

            try
            {

                SqlCeCommand command1 = new SqlCeCommand(@"INSERT INTO Game_type (Mark) VALUES (@mark)", Connection);
                command1.Parameters.AddWithValue("@mark", Mark);

                int result = command1.ExecuteNonQuery();

                if (result > 0)
                {
                    flag = true;
                    MessageBox.Show("Uspjesno ste dodali tip igre!!!");
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
