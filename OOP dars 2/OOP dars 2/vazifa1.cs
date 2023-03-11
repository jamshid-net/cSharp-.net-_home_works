namespace OOP_dars_2
{
    class Time
    {
        private string hour="";
        private string minute="";
        private string second = "";
        
        public int Hour
        {
            get
            {
                if (Hour >= 0 && Hour < 24)
                {
                    
                    return Hour;
                }
                 return 0;

            }
            set
            {
                if (value >= 0 && value < 10)
                {
                    this.hour = "0" + value.ToString();

                }
                else if (value >= 10 && value < 24) this.hour = value.ToString();
                else Console.WriteLine("hour format is wrong!");
            }
        }
        public int Minute
        {
            get
            {
                if (Minute >= 0 && Minute < 60)
                {
                    
                    return Minute;
                }
                 return 0;

            }
            set
            {
                if (value >= 0 && value < 10)
                {
                    this.minute= "0" + value.ToString();

                }
                else if (value >= 10 && value < 60) this.minute= value.ToString();
                else Console.WriteLine("minute format is wrong!");
            }
        }
        public int Second
        {
            get
            {
                if (Second >= 0 && Second < 60)
                {
                    
                    return Second;
                }
                 return 0;

            }
            set
            {
                if (value >= 0 && value < 10)
                {
                    this.second= "0" + value.ToString();

                }
                else if (value >= 10 && value < 60) this.second= value.ToString();
                else Console.WriteLine("second format is wrong!");
            }
        }
        public Time() : this(Convert.ToInt32(DateTime.Now.Hour))
        { }
        public Time(int _Hour) :this(_Hour,Convert.ToInt32(DateTime.Now.Minute))
        { }
        public Time(int _Hour, int _Minute) : this(_Hour,_Minute,Convert.ToInt32(DateTime.Now.Second))
        { }
        public Time(int _Hour, int _Minute, int _Second)
        { 
            this.Hour = _Hour;
            this.Minute = _Minute;
            this.Second = _Second;
        }
        private bool CheckHour()
        {
            bool isNull = string.IsNullOrEmpty(hour);
            return isNull;
        }
        private bool CheckMinute()
        {
            bool isNull = string.IsNullOrEmpty(minute);
            return isNull;
        }
        private bool CheckSecond()
        {
            bool isNull = string.IsNullOrEmpty(second);
            return isNull;
        }
        
        public void GetTime()
        {
            if(!CheckHour() && !CheckMinute() && !CheckSecond())
            Console.WriteLine($"{this.hour}:{this.minute}:{this.second}");

        }

    }

    
}
