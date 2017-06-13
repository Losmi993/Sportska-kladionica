using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KladionicaNova.Models
{
    class TicketEventModels
    {
        public int Ticket_Id { get; set; }
        public int Event_Id { get; set; }

        public TicketEventModels(int ticket_Id, int event_Id)
        {
            Ticket_Id = ticket_Id;
            Event_Id = event_Id;
        }
    }
}
