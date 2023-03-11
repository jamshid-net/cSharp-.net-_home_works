using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_6.Task_4.Classes
{
    internal class Pitcher :BaseballPlayer
    {
        public double innings { get; set; }
        public int earnedRuns { get; set; }

        public double earnedRunsAverage()
        {
            return (9.0 * earnedRuns) / innings;
        }
    }
}
