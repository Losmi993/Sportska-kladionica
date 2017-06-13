using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KladionicaNova.Models
{
    class GameTypeModels
    {
        public int Id { get; set; }
        public string Mark { get; set; }

        public GameTypeModels(int id, string mark)
        {
            Id = id;
            Mark = mark;
        }
    }
}
