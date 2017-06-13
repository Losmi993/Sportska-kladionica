using System;
using System.Collections.Generic;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KladionicaNova.Repository
{
    class TicketRepository
    {
        public static string GetTimeTicketQuery()
        {

            string query;
            query = @"SELECT Time FROM Ticket";
            return query;
        }

        public static bool AddTicket(DateTime Time, int TicketData_Id)
        {
            SqlCeConnection Connection = DataBaseConnection.Instance.Connection;

            bool flag = false;

            try
            {

                SqlCeCommand command1 = new SqlCeCommand(@"INSERT INTO Ticket (TicketData_Id, Time) VALUES (@ticketDataId, @time)", Connection);
                command1.Parameters.AddWithValue("@ticketDataId", TicketData_Id);
                command1.Parameters.AddWithValue("@time", Time);

                int result = command1.ExecuteNonQuery();

                if (result > 0)
                {
                    flag = true;
                    MessageBox.Show("Uspjesno ste dodali tiket!!!");
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
