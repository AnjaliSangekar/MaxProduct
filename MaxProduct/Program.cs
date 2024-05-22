using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxProduct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductMax();
            Console.WriteLine();
            //muliplyLength();


            int[] nums = { 1, 3, 5, 7, 9 };
            int[] new_nums = muliplyLength(nums);
            Array.ForEach(new_nums, Console.WriteLine);


            Console.WriteLine();

            SumSquareNo();

        }

        public static void ProductMax()
        {
            int[] a = new int[] { 1, 3, 4, 5, 2 };

            Console.WriteLine("Array:  [{0}]", string.Join(", ", a));

            int max = a[0] * a[1];

            for (int i = 0; i < a.Length - 2; i++)
            {
                max = Math.Max(max, a[i] * a[i + 1]);
            }

            Console.WriteLine("Max Product");
            Console.WriteLine(max);
        }

        public static int[] muliplyLength(int[] nums)
        {
            //int[] a = new int[] { 1, 3, 5, 7, 9 };

            Console.WriteLine("Array: [{0}]", string.Join(", ", nums));

            var len = nums.Length;
            Console.WriteLine("Multiply by length");
            return nums.Select(x => x * len).ToArray();

        }


        public static void SumSquareNo()
        {
            int[] a = new int[] { 1, 2, 3 };

            Console.WriteLine("Array:  [{0}]", string.Join(", ", a));

            Console.WriteLine("Sum of square no");

            Console.WriteLine(a.Sum(x => x * x));

        }


    }
}

