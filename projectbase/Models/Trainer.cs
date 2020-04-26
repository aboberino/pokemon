using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace projectbase.Models
{
    public class Trainer
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Sprite { get; set; }
        public string Pokemon1 { get; set; }
        public string Pokemon2 { get; set; }
        public string Pokemon3 { get; set; }
        public string Pokemon4 { get; set; }
        public string Pokemon5 { get; set; }
        public string Pokemon6 { get; set; }
    }
}
