using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace dagatph
{
    internal class DataModel
    {
        public float PH { get; set; }
        public string Location { get; set; }
        public DateTime DateTime { get; set; }
        public string Description { get; set; }
        

        public string ToCsvString()
        { 
            return $"{DateTime},{PH},{Location},{Description}";
        }
    }
}