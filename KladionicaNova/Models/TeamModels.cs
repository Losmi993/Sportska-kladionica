using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KladionicaNova.Models
{
    class TeamModels
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public TeamModels(int id, string name)
        {
            Id = id;
            Name = name;
        }


    }
}
