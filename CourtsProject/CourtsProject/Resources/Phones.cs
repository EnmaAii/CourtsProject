using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace CourtsProject.Resources
{
    public class Phones
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; } 
        public string Phone { get; set; }
    }
}
