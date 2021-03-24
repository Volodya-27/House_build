using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp9.interfaces;

namespace ConsoleApp9.clases
{
    class Door: IPart
    {
        private int number_door;
        public int Number_door { get => number_door; set { number_door = value; } }
        public string Build()
        {
            return  $"install number Door {number_door}";
        }
    }

}
