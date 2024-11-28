using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDungeon
{
    internal class DungeonExploration
    {
        


        private static void runMenu(string message)
        {
            bool continuous = true;
            Console.WriteLine(message);
            while (continuous)
            {
                string input = Console.ReadLine();
                if (input == "ENTER")
                {
                    Console.WriteLine("Let's begin");
                }
                else if (input == "EXIT")
                {
                    continuous = false;
                }

            }

        }
    }
}

