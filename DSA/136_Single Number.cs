using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    public class _136_Single_Number
    {
        public static int SingleNumber(int[] nums= null)
        {
            int[] arr = { 4, 1, 2, 1, 2 };
            // this is use to remove duplicate element from array and it will only print unique one 
            List<int> a = nums.ToList();
            a = a.GroupBy(n => n).Where(v => v.Count() == 1).Select(u => u.Key).ToList();
            return a[0];
        }
    }
}
