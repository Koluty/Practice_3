using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_3
{
    internal class FileWrite : IWrite
    {
        public void write(string patch, double n)
        {
            using (StreamWriter sw = new StreamWriter(patch, false, System.Text.Encoding.Default))
            {
                sw.WriteLine("Середне арифметичне = " + n.ToString());
                sw.Close();
            }
        }
    }
}
