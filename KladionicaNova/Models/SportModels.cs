using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KladionicaNova.Models
{
    class SportModels
    {
        public int Id { get; set; }
        public string NameSport { get; set; }

        public SportModels(int id, string nameSport)
        {
            Id = id;
            NameSport = nameSport;
        }
    }
}
