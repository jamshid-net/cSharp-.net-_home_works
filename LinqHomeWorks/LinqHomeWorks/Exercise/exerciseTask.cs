namespace LinqHomeWorks.Exercise
{
    class exerciseTask
    {
        public static void Task4()
        {
            int[] arr = { 78,78, -9, 0, 23, 54, 21, 7, 86 };
            var task4 = (from i in arr 
                        orderby i descending 
                        select i).Distinct().Take(5);
            foreach (var item in task4)
            {
                Console.WriteLine(item);
            }
            

        }
        public static void Task5()
        {
            int[] arr = { 7, 2, 30 };
            var task5 = (from i in arr 
                         where (i*i)>20 
                         select i);
            foreach (var item in task5)
            {
                Console.WriteLine(item);
            }
        }
        public static void Task17()
        {
            int[,] ar2 = { { 1, 2, 3, 4 }, { 1, 2, 3, 4 }, { 1, 2, 3, 4 }, { 1, 2, 3, 4 } };
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    ar2[i, j] = i + 1;
                    Console.Write(ar2[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("------------");
            int[,] arr = new int[4,4];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    arr[i, j] = i+1;
                    Console.Write(arr[i,j]+" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            var task17 = from int i in arr
                         select i;
                         
            foreach (var item in task17)
            {
               
            }

                       

                        


        }
    }
}
