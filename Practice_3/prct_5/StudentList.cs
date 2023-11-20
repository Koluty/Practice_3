using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Practice_3.prct_5
{
    public class StudentList
    {
        public List<Student> students = new List<Student>();
        XmlSerializer serializer = new XmlSerializer(typeof (List<Student>));
        public void add(Student student) { students.Add(student); }
        public void remove(int i) { students.RemoveAt(i); }
        public void sort()
        {
            SortByYearOfBirth sortByYearOfBirth = new SortByYearOfBirth();
            students.Sort(sortByYearOfBirth);
        }
        public void writeFile(string fileName)
        {
            FileStream fileStream = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None);
            serializer.Serialize(fileStream, students);
            fileStream.Close();
        }
        public void readFile (string fileName)
        {
            FileStream fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.None);
            students = serializer.Deserialize(fileStream) as List<Student>;
            fileStream.Close();
        }
    }
}
