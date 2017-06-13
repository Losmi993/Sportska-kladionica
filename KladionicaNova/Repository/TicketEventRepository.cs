using System;
using System.Collections.Generic;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KladionicaNova.Repository
{
    class TicketEventRepository
    {

        public static void AddTicket_Event(int Ticket_Id, int Event_Id)
        {
            SqlCeConnection Connection = DataBaseConnection.Instance.Connection;

            try
            {
                SqlCeCommand command = new SqlCeCommand(@"INSERT INTO Ticket_Event (Ticket_Id, Event_Id) VALUES (@ticketID, @eventID)", Connection);
                command.Parameters.AddWithValue("@ticketID", Ticket_Id);
                command.Parameters.AddWithValue("@eventID", Event_Id);


                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Uspjesno ste povezali dogadaj i tiket!!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
