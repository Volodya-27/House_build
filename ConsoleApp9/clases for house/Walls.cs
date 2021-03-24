using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp9.interfaces;

namespace ConsoleApp9.clases
{
    class Walls: IPart
    {
        private int number_walls;
        public int Number_walls { get => number_walls; set { number_walls = value; } }

        public string Build()
        {
            return $"Build Walls {number_walls} ";
        }
    }
}
