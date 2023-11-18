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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Task_1 task = new Task_1((int)numericUpDown1.Value, (int)numericUpDown2.Value, (int)numericUpDown3.Value);
            int product = task.CalculateProduct();
            if (product == 1)
                ResultLabel.Text = "Жоден із чисел не відповідав умові, тому їхній добуток не було розраховано.";
            else 
                ResultLabel.Text = product.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Task_2 task = new Task_2((int)numericUpDown1Task2.Value, (int)numericUpDown2Task2.Value);
            int product = task.CalculateProductInRange();
            if (product == 1)
                result_task2.Text = "У діапазоні не було чисел кратних 6, тому добуток не було розраховано";
            else 
                result_task2.Text = product.ToString();
        }
    }
}
