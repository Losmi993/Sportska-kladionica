﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KladionicaNova.Models
{
    class TicketDataModels
    {
        public int Id { get; set; }
        public string Text { get; set; }

        public TicketDataModels(int id, string text)
        {
            Id = id;
            Text = text;
        }
    }
}
