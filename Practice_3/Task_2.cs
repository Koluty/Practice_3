using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_3
{
    public class Task_2
    {
        int start;
        int end;

        public Task_2(int start, int end)
        {
            this.start = start;
            this.end = end;
        }
        public int CalculateProductInRange()
        {
            int product = 1;
            for (int i = start; i <= end; i++)
                if(i % 6 == 0)
                    product *= i;
              
            return product;
        }
    }
}
