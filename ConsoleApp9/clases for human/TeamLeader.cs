using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp9.interfaces;
namespace ConsoleApp9.clases_for_human
{
    class TeamLeader : IWorker
    {
        private int experience;

        public void Check_work(int a)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            if (a==1)
                Console.WriteLine("Build Basement");
            if(a==2)
                Console.WriteLine("Build Basement + Build Walls");
            if (a == 3)
                Console.WriteLine("Build Basement + Build Walls + Build Window");
            if (a == 4)
                Console.WriteLine("Build Basement + Build Walls + Build Window+ Build Door"); 
            if (a == 5)
                Console.WriteLine("Build Basement + Build Walls + Build Window + Build Door + Build Roof");

            Console.ForegroundColor = ConsoleColor.White;

        }
        public int Exparience { get => experience; set { experience = value; } }
        public string name { get; set; }
        
    }
}
