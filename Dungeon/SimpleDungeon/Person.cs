using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDungeon
{
    internal class Person
    {
        private Position position { get; set; }
        
        public Person()
        {
            position = new Position(0, 0);
        }
    }
}
