using System;
using System.Collections.Generic;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KladionicaNova.Repository
{
    class TicketDataRepository
    {

        public static void  DeleteData()
        {
                SqlCeConnection Connection = DataBaseConnection.Instance.Connection;

                SqlCeCommand command = new SqlCeCommand(@"DELETE FROM TicketData", Connection);
                command.ExecuteNonQuery();
        }

   
        public static int GetIdByTicketDataText(string name)
        {
            SqlCeConnection Connection = DataBaseConnection.Instance.Connection;

            SqlCeCommand command = new SqlCeCommand(@"SELECT Id FROM TicketData WHERE Text = @name", Connection);
            command.Parameters.AddWithValue("@name", name);
            SqlCeDataReader reader = command.ExecuteReader();

            reader.Read();

            int result = (int)reader["Id"];
            reader.Close();

            return result;
        }
      

        public static List<String> Text
        {
            get
            {
                SqlCeConnection Connection = DataBaseConnection.Instance.Connection;

                SqlCeCommand command = new SqlCeCommand(@"SELECT Text FROM TicketData", Connection);
                SqlCeDataReader reader = command.ExecuteReader();
                var list = new List<String>();

                while (reader.Read())
                {
                    string result = reader["Text"].ToString();
                    list.Add(result);

                }
                reader.Close();
                return list;
            }
        }

        public static bool AddData(string text)
        {
            SqlCeConnection Connection = DataBaseConnection.Instance.Connection;

            bool flag = false;

            try
            {

                SqlCeCommand command1 = new SqlCeCommand(@"INSERT INTO TicketData (Text) VALUES (@text)", Connection);
                command1.Parameters.AddWithValue("@text", text);

                int result = command1.ExecuteNonQuery();

                if (result > 0)
                {
                    flag = true;
                    MessageBox.Show("Uspjesno ste dodali podatke!!!");
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
