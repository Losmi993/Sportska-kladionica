using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KladionicaNova.Models
{
    class EventModels
    {
        public int Id { get; set; }
        public int Sport_Id  { get; set; }
        public int Team_Id { get; set; }
        public string Time { get; set; }
        public int League_Id { get; set; }
        public int Game_type_Id { get; set; }
        public float Quota { get; set; }
        public int Team_Id1 { get; set; }

        public EventModels(int id, int sport_Id, int team_Id, string time, int league_Id, int game_type_Id, float quota, int team_Id1)
        {
            Id = id;
            Sport_Id = sport_Id;
            Team_Id = team_Id;
            Time = time;
            League_Id = league_Id;
            Game_type_Id = game_type_Id;
            Quota = quota;
            Team_Id1 = team_Id1;
        }
    }
}
