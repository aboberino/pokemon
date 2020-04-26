using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using SQLite;

namespace projectbase.Models
{
    class Team
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public int TrainerID { get; set; }
        public int PokemonID { get; set; }
    }
}
