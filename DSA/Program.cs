using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = { 4, 1, 2, 1, 2 };
            SingleNumber(arr);
        }

        public static int SingleNumber(int[] nums)
        {
            // this is use to remove duplicate element from array and it will only print unique one 
            List<int> a = nums.ToList();
            a= a.GroupBy(n => n).Where(v => v.Count() == 1).Select(u=> u.Key).ToList();
            return a[0];
        }
    }
}
