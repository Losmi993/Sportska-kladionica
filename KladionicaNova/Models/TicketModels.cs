using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KladionicaNova.Models
{
    class TicketModels
    {
        public int Id { get; set; }
        public int TicketData_Id { get; set; }
        public string Time { get; set; }

        public TicketModels(int id, int ticketDataId, string time)
        {
            Id = id;
            TicketData_Id = ticketDataId;
            Time = time;
        }
    }
}
