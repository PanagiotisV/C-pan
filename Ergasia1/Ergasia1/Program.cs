using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ergasia1
{
    class Program
    {
        static void Main(string[] args)
        {
            int G = 0;
            for (int i = 0; i < 2; i++)
            {
                if (args[i].StartsWith("G")) { G = G + 1; }
            }
            Console.WriteLine("The number of names with G are: " + G);
            string rd = Console.ReadLine();
        }
    }
}
