using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms[0];
            form.Show();
            this.Close();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            ArraysAverage a = new ArraysAverage(100);
            FileWrite fileWrite = new FileWrite();
            FileRead fileRead = new FileRead();
            ShowArray show = new ShowArray();
            string patch = @"C:\Users\Kotov\Desktop\array.txt";
            string patch_result = @"C:\Users\Kotov\Desktop\avarage.txt";
            fileRead.read(patch, a);
            double result = a.Calculate();
            fileWrite.write(patch_result, result);
            array.Text = show.WriteArray(a.a);
            avarage.Text = result.ToString();
        }
    }
}
