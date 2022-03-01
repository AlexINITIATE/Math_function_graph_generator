using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Math_function_graph_generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double min = double.Parse(textBox1.Text);
            double max = double.Parse(textBox2.Text);
            double h   = double.Parse(textBox3.Text);
            if (listBox1.SelectedItem == "1) y = sin(x)")
            {
                double x, y;
                this.chart1.Series[0].Points.Clear();
                x = min;
                while (x < max)
                {
                    y = Math.Sin(x);
                    this.chart1.Series[0].Points.AddXY(x, y);
                    x += h;
                }
            }
            if (listBox1.SelectedItem == "2) y = cos(x)")
            {
                double x, y;
                this.chart1.Series[1].Points.Clear();
                x = min;
                while (x < max)
                {
                    y = Math.Cos(x);
                    this.chart1.Series[1].Points.AddXY(x, y);
                    x += h;
                }
            }
        }
    }
}
