using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp9.interfaces;

namespace ConsoleApp9.clases
{
    class House 
    {
        //private bool check(double a, string a1)
        //{
        //    if (a == 0)
        //    {
        //        Console.WriteLine($"it is impossible to build a house");
        //        return false;
        //    }
        //    else
        //    {
        //        Console.WriteLine(a1);
        //        return true;
        //    }
        //}
        
        public bool Build_Basement()
        {
            Basement bs = new Basement();
            bs.Number_basmend = 1;
            Console.WriteLine(bs.Build());
            return true;
        }
        public bool Build_Walls()
        {
            Walls wl = new Walls();
            wl.Number_walls = 4;
            Console.WriteLine(wl.Build());
            return true;
        }
        public bool Build_Window()
        {
            Window wd = new Window();
            wd.Number_window = 4;
            Console.WriteLine(wd.Build());
            return true;
        }
        public bool Build_Door()
        {
            Door dr = new Door();
            dr.Number_door = 1;
            Console.WriteLine(dr.Build());
            return true;
        }
        public bool Build_Roof()
        {
            Roof rf = new Roof();
            rf.Square_roof = 1;
            Console.WriteLine(rf.Build());
            return true;
        
        }
       
    }
}
