using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void Sum(int[] numbers, int initialValue)
            {
                int result = initialValue;
                foreach (var n in numbers)
                {
                    result += n;
                }
                Console.WriteLine(result);
            }

            int[] nums = { 1, 2, 3, 4, 5 };
            Sum(nums, 10);

            // Sum(1, 2, 3, 4);     // так нельзя - нам надо передать массив
        }
    }
}
