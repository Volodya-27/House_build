using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp9.interfaces;

namespace ConsoleApp9.clases
{
    class Basement: IPart
    {
        private double number_basmend;
        
        public double Number_basmend { get => number_basmend; set { number_basmend = value; } }

        //public bool built { get; set; }

        public string Build() { return $"Build basment {number_basmend}"; } 
        
    }
}
