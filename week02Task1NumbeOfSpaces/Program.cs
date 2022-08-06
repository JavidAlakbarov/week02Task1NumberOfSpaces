using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week02Task1NumbeOfSpaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countl = 0, countt = 0, count = 0;

            foreach (char c in "This is a test string")
            {
                countt++;
                if (char.IsLetter(c))
                {
                    countl++;
                }
            }
            count = countt - countl;
            Console.WriteLine("No. of spaces are: " + count);
        }
    }
}
