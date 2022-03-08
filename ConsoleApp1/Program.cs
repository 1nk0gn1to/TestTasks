using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        
        public static double Calculate(string userInput)
        {
            string[] words = userInput.Split();
            var sum = double.Parse(words[0]);
            var percents = double.Parse(words[1]) / 100;
            var month = double.Parse(words[2]);
            sum += ((sum * percents) / 12) * month;
            return sum;
        }
        static void Main(string[] args)
        {
            var enter = Console.ReadLine();
            var totalSum = Calculate(enter);
            Console.WriteLine(totalSum);
        }
    }
}
