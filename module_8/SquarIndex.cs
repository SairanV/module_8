using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module_8
{
    public class SquarIndex
    {
        private double[] array;

        public SquarIndex(int size)
        {
            array = new double[size];
        }

        public double this[int index]
        {
            get
            {
                if (index >= 0 && index < array.Length)
                {
                    return array[index];
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
            set
            {
                if (index >= 0 && index < array.Length)
                {
                    array[index] = value * value; // Возводим значение в квадрат перед установкой
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
        }
    }
}
