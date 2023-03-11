namespace OOP_4
{
    static class MyString
    {
        public static string CapitalizeS(string s)
        {
            s = s.Replace(s[0], char.ToUpper(s[0]));
            return s;
        }
        public static string HightLenghtS(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                s = s.Replace("  ", " ");

            }
            string[] arr = s.Split(' ').ToArray();
            int max = int.MinValue;
            string temp=null;
            foreach (var item in arr)
            {
                if(item.Length > max)
                {
                    max = item.Length;
                    temp = item;
                    
                }

            }
            return temp;
        }

        public static string RemoveSpaces(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
               s = s.Replace("  "," ");

            }
            return s;
          
        }

    }
}
