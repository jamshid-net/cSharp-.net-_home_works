namespace OOP_Dars_1
{

    public class Phone
    {
        
        public string model = "";
        public string cpu = "";
        public string camera = "";
        public string gpu = "";
        public int battery;
        private string color = "Black";
        public int displaySize;
        public string displayType = "";
        public Phone(string color)
        {
            this.color = color;

        }
        public Phone()
        {
           

        }
        public void Unlock()
        {
            Console.WriteLine(this.model+" "+this.color + " is unlocked!");
        }
        public void Lock()
        {
            Console.WriteLine(this.model + " is locked");
        }

    }
}
