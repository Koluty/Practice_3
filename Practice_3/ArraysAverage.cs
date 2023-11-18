using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_3
{
    public class ArraysAverage
    {
        public int[] a;
        int length = 0;
        public int Length { get { return length; } set { length = value; } }
        public ArraysAverage(int n) { a = new int[n]; }
        public double Calculate()
        {
            Array.Resize(ref a, length);
            double sum = 0;
            for (int i = 0; i < length; i++)
                sum += a[i];
            return sum / length;
        }
    }
}

