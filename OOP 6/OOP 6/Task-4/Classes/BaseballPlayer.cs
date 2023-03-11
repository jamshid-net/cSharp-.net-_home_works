using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_6.Task_4.Classes
{
    internal class BaseballPlayer : Player
    {
        public int bats { get; set; }

        public int hits { get; set; }

        public double AverageAtBats()
        {
            return hits/ bats;
        }
    }
}
