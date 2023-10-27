using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = 5; 
            SquarIndex indexer = new SquarIndex(size);

            for (int i = 0; i < size; i++)
            {
                indexer[i] = i;
            }

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Element {i}: {indexer[i]}");
            }
        }
    }
}
