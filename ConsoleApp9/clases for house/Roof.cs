using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp9.interfaces;

namespace ConsoleApp9.clases
{
    class Roof: IPart
    {
        private double square_roof;

        public double Square_roof { get => square_roof; set { square_roof = value; } }

        public string Build()
        {
           return  $"Build Roof {square_roof}";
        }
    }
}
