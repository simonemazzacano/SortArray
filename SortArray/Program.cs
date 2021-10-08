using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 10, 2, 9, 34, -2, 4, 20 };
            Array.Sort(arr);
            foreach (int val in arr)
            {
                Console.Write(val + " ");
            }

            Console.ReadKey();
        }
    }
}
