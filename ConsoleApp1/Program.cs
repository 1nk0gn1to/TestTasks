using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main()
        {
            var buffer = new List<string>();
            buffer.AddRange(File.ReadAllLines(@"C:\Users\MegaComp\Desktop\1.txt"));
            foreach (var line in buffer)
            {
                var generalLine = line + line + line;
                File.AppendAllText(@"C:\Users\MegaComp\Desktop\2.txt", generalLine);
            }
        }
    }
}
