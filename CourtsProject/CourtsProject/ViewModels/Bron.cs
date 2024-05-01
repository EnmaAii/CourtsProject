using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using SQLite;

namespace CourtsProject.Resources
{
    public class Bron
    {
        [PrimaryKey]
        public string Phone { get; set; }
        public string Court { get; set; }
        public DateTime Date { get; set; }
        public string Comment { get; set; }
    }
}
