using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace projectbase.Models
{
    class PokemonTable
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Sprite { get; set; }
    }
}
