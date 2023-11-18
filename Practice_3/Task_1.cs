using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_3
{
    public class Task_1
    {
        int x, y, z;

        public Task_1(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public int CalculateProduct()
        {
            bool xInRange = (x > 10 && x < 15);
            bool yInRange = (y > 10 && y < 15);
            bool zInRange = (z > 10 && z < 15);

            int product = 1;

            if (xInRange || yInRange || zInRange)
            {
                if (xInRange)
                    product *= x;
                if (yInRange)
                    product *= y;
                if (zInRange)
                    product *= z;
            }
            return product;
        }
    }
}
