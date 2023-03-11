using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_6.Task_4.Classes
{
    internal class SoccerPlayer
    {
        public int minutes { get; set; }
        public int goals { get; set; }

        public double goalsPerGame()
        {
            return goals / minutes;
        }
    }
}
