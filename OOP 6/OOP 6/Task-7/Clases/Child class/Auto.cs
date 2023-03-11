using OOP_6.Task_7.Clases.Father_class;
using OOP_6.Task_7.Interface;

namespace OOP_6.Task_7.Clases.Child_class
{
    internal class Auto : Texnika, IMahsulot, IElektronika
    {
        public double price { get; set; }
        public string madeIn { get; set; }

        public string model { get; set; }
        public double volt { get; set; }

        public string carType { get; set; }
        public string color { get; set; }



    }
    public class Solution
    {
        public bool HasCycle(ListNode head)
        {
           ListNode temp = head;
            if (head.next == null) return false;
            else return true;
            int? a;

            while(head.next != null)
            {
                head= head.next;
            }
            head.next = temp;    
           



        }
    }
}
