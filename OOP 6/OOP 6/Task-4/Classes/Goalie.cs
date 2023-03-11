namespace OOP_6.Task_4.Classes
{
    class Goalie : SoccerPlayer
    {
        public int goalsAllowed { get; set; }

        public double goalsAllowedAverage()
        {
            return goalsAllowed / (minutes / goals);
        }
    }
}
