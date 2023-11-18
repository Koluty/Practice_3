using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_3
{
    internal class ShowArray
    {
        public string WriteArray(int[] arr)
        {
            string s = "";
            foreach (int i in arr)
                s += i.ToString() + " ";
            return s;
        }
    }
}
