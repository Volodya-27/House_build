using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp9.interfaces;
namespace ConsoleApp9.clases_for_human
{
    class Team : IWorker
    {
        public Worker[] worker = { new Worker {name ="Bob", Id=123 },
            new Worker {name ="Ivan", Id=13 },
            new Worker {name ="Alex", Id=199 },
            new Worker {name ="Jeck", Id=1623 },
            new Worker {name ="Koil", Id=666 }};
        
        public string name { get; set; }
        
     
    }
}
