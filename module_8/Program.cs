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
            SquaredArray myArray = new SquaredArray(5);

            myArray[0] = 1;
            myArray[1] = 2;
            myArray[2] = 3;
            myArray[3] = 4;
            myArray[4] = 5;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Элемент[{i}] = {myArray[i]}");
            }

            Console.ReadLine();
        
        }
    }
}
