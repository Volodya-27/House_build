using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp9.interfaces;
using ConsoleApp9.clases;

namespace ConsoleApp9.clases_for_human
{
    class Worker :House, IWorker
    {
      
      //  public bool Work_check { get => work_check; set { work_check = value; } }
        private int id;
        public int Id { get => id; set { id = value; } }
        public string name { get ; set ; }

    }
}
