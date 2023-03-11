namespace DelegateHomeWork.HomeWork
{
    internal class AnonymousMethod
    {
        
        public delegate int Print(List<int> list);

        public static void Run()
        {
            Print print = delegate (List<int> list)
           {
               int number = int.MinValue;
               for (int i = 0; i < 50; i++)
               {
                   list.Add((new Random()).Next(100));
                   Console.Write(list[i]+" ");
                   if (list[i] % 2 != 0  && number < list[i])
                   {
                      number = list[i];
                       
                   }
               }
               return number;
           };
            List<int> list2 = new();
           
            Console.WriteLine(print(list2));
        }

    }
    static class AnonymousMethod2
    {

        public delegate string Print(string satr);
       
        

        public static void Run(string s)
        {

        
            Print p = delegate (string s)
            {
                s = s.Replace("  ", " ");
                string[] arr = s.Split(' ').ToArray();
                int max = int.MinValue;
                string myWord = null;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i].Length%2==0 && arr[i].Length>max)
                    {
                        myWord= arr[i];
                        
                    }

                }


                return myWord;
            };
            Console.WriteLine(p(s));
       
        }


    }
}
