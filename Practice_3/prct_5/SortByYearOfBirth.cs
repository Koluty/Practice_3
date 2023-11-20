using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_3.prct_5
{
    public class SortByYearOfBirth : IComparer<Student>
    {
        public int Compare(Student student, Student student1)
        {
            if (student.YearOfBirth < student1.YearOfBirth) return -1;
            if (student.YearOfBirth > student1.YearOfBirth) return 1;
            return 0;
        }
    }
}
