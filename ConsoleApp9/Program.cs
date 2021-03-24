using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp9.clases;
using ConsoleApp9.clases_for_human;
namespace ConsoleApp9
{
    class Program
    {
        public static bool Check(bool b1)
        {
            if (b1 == true)
                return true;
            else
            {
                Console.WriteLine($"it is impossible to build a house");
                return false;
            }
        }
        static void Main(string[] args)
        {
            int check_etap = 0;
            String dom =
            @"
             _    ~ ~ ~
            / \  ||
           /   \ ||
          /     \||
         /       \|
        /         \
       /           \
      /             \
    _/_______________\_
    |                 |
    |    _ _          |
    |   |_|_|     __  |
    |   |_|_|    |  | |
    |            |  | |
    |            |  | |
    |____________|__|_|
------------------------------
";
            bool b1= false, b2=false, b3=false, b4=false;
            Team team = new Team {name="The best Builder"};
            TeamLeader teamLeader = new TeamLeader { name = "Volodya", Exparience = 30};
           
            b1 = team.worker[0].Build_Basement();
            check_etap++;
            if (Check(b1) == true)
            {
                b2 = team.worker[1].Build_Walls();
                check_etap++;
            }
            teamLeader.Check_work(check_etap);

            if (Check(b2) == true)
            {
                b3 = team.worker[2].Build_Window();
                check_etap++;
            }

            b4 = team.worker[3].Build_Door();
            check_etap++;
            if (Check(b3 == true) && Check(b4 == true))
            {
                team.worker[4].Build_Roof();
                check_etap++;
                Console.WriteLine($"\n\n\n\n\nBuild House end {dom}");
            }
            Console.ReadKey();
        }
    }
}
