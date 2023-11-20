using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_3.prct_5
{
    public partial class Form3 : Form
    {
        StudentList studentList = new StudentList();
        string path = @"C:\Users\Kotov\Desktop\data.txt";
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms[0];
            form.Show();
            this.Close();
        }
        //Custom Format for date time picker
        private void Form3_Load(object sender, EventArgs e)
        {
            year_picker_gui.Format = DateTimePickerFormat.Custom;
            year_picker_gui.CustomFormat = "yyyy";
            year_picker_gui.ShowUpDown = true;
        }
        //Add element to list
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var student = new Student(year_picker_gui.Value.Year, Convert.ToInt32(numberSchoolPicker_GUI.Value), name_GUI.Text, surname_GUI.Text);
                studentList.add(student);
                dataGridView1.Rows.Add(studentList.students[studentList.students.Count - 1].Surname + " " + studentList.students[studentList.students.Count - 1].Name,
                    studentList.students[studentList.students.Count - 1].YearOfBirth, studentList.students[studentList.students.Count - 1].SchoolNumber);
            }
            catch { MessageBox.Show("Помилка у вхідних даних"); }
        }
        //Delete element of list
        private void button3_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.SelectedRows.Count > 0 ? dataGridView1.SelectedRows[0].Index : -1;
            if (rowIndex >= 0)
            {
                dataGridView1.Rows.RemoveAt(rowIndex);
                studentList.remove(rowIndex);
            }
        }
        //Write in File
        private void button4_Click(object sender, EventArgs e)
        {
            studentList.writeFile(path);
            MessageBox.Show("Дані записані");
        }
        //Read from File
        private void button5_Click(object sender, EventArgs e)
        {
            studentList.readFile(path);
            dataGridView1.Rows.Clear();
            for(int i = 0; i < studentList.students.Count; i++)
                dataGridView1.Rows.Add(studentList.students[i].Surname + " " + studentList.students[i].Name,
                    studentList.students[i].YearOfBirth, studentList.students[i].SchoolNumber);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            studentList.sort();
            studentList.students.Sort();
            dataGridView2.Rows.Clear();
            foreach (Student student in studentList.students)
                if (student.SchoolNumber == Convert.ToInt32(schoolNumberForSort.Value))
                    dataGridView2.Rows.Add(student.Surname + " " + student.Name, student.YearOfBirth, student.SchoolNumber);
        }
    }
}
