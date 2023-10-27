using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic7
{
    class ArrayContainer
    {
        private int[] array;

        public ArrayContainer(int[] arr)
        {
            array = arr;
        }

        public static bool operator >(ArrayContainer obj1, ArrayContainer obj2)
        {
            return obj1.GetSum() > obj2.GetSum();
        }

        public static bool operator <(ArrayContainer obj1, ArrayContainer obj2)
        {
            return obj1.GetSum() < obj2.GetSum();
        }

        private int GetSum()
        {
            int sum = 0;
            foreach (int element in array)
            {
                sum += element;
            }
            return sum;
        }
    }

 
}
