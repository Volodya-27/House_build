using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp9.interfaces;

namespace ConsoleApp9.clases
{
    class Window: IPart
    {
        private int number_window;
        public int Number_window { get => number_window; set { number_window = value; } }

        public string Build()
        {
            return $"Install {number_window} window";
        }
    }
}
