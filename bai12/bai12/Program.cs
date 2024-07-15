using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai12
{
    internal class Program
    {
        static void Main(string[] args)
        {
             int[] arr = { 34, 7, 23, 32, 5, 62 };
            Console.WriteLine("Mảng ban đầu: " + string.Join(", ", arr));

            Sort sort = new Sort();
            sort.QuickSort(arr, 0, arr.Length - 1);
            Console.WriteLine("Mảng sau khi sắp xếp: " + string.Join(", ", arr));
        }
    }
}
