namespace OOP_dars_2
{
    class Book
    {
        private string bookName;
        private string[] authors;
        private long isbn;
        private double price;


        public string BookName { get => bookName; set => bookName = value; }

        public string[] Authors { get => authors; set => authors = value; }

        public long ISBN
        {
            get => isbn;
            set
            {
                if (value.ToString().Length == 13) isbn = value;
                else Console.WriteLine("Isbn lenght is not 13, or is not correct");

            }
        }
        public double Price
        {
            get => price;
            set
            {
                if (value >= 0) 
                    price = value;
            }
        }


        public Book()
        {

        }
        public void GetInfo()
        {
            Console.WriteLine("Book name: " + bookName);
            int i = 1;
            foreach (var item in authors)
            {
                Console.WriteLine(i + ":" + item);
                i++;
            }
        }





    }




}

