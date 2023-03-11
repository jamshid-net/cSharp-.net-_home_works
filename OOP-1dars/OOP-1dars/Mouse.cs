using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mouse
{

    public class Mouse
    {
        public string Brand;
        public string Model;
        public string Type;
        public string Color;
        public string typeOfSensor;
        public double weight;
        public int Price;
        public string ForWhat;
        public bool IsRgb;

        public string RightButton()
        {
            return "Right button Clicked";
        }
        public string LefttButton()
        {
            return "Left Button Clicked";
        }
        public int MoveX(int x)
        {
            return x;
        }
        public int MoveY(int y)
        {
            return y;
        }
        public int ScrollDown(int d)
        {
            return ScrollDown(d - 1);
        }
        public int ScrollUp(int u)
        {
            return ScrollUp(u - 1);
        }

    }






}

