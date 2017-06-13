using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KladionicaNova.Models
{
    class LeagueModels
    {
        public int Id { get; set; }
        public string NameLeague { get; set; }

        public LeagueModels(int id, string nameLeague)
        {
            Id = id;
            NameLeague = nameLeague;
        }
    }
}
