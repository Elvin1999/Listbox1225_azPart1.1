using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            List<string> cars = new List<string>
            {
                "Audi",
                "Mercedes",
                "Chevrolet",
                "Bugatti"
            };

            //listBox1.DataSource = cars;
           // listBox1.SelectedIndex = 2;

            listBox1.Items.AddRange(cars.ToArray());

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var car = listBox1.SelectedItem as string;
            //label1.Text = car;
            //MessageBox.Show(car);


            var cars= listBox1.SelectedItems;
            var sb=new StringBuilder();
            foreach (var item in cars)
            {
                sb.AppendLine(item.ToString());
            }
            label1.Text = sb.ToString();    
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            var car = listBox1.SelectedItem as string;
            listBox1.Items.Remove(car);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var newCar = textBox1.Text;
            listBox1.Items.Add(newCar);
            textBox1.Text = String.Empty;
        }
    }
}
