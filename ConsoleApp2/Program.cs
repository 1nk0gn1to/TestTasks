using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText(@"C:\Users\MegaComp\Desktop\4.txt");
            string pattern = @"\b\s\b";
            string symbol = "\n";
            Regex regex = new Regex(pattern);
            text = regex.Replace(text, symbol);
            File.WriteAllText(@"C:\Users\MegaComp\Desktop\5.txt", text);
        }
    }
}
