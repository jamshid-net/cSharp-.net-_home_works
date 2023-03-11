using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    internal class DelegateList
    {
        public delegate (int, int) Delegat(List<int> nums);
        
        public static (int, int)  GetValues(List<int> nums)
        {
            var tuple = (nums.Min(), nums.Max());

            Delegat delegat=GetValues;
            delegat.Invoke(nums);
            return tuple;
        }


    }
}
