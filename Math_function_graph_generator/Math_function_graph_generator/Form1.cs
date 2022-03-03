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
            double x, y;

            switch (listBox1.SelectedIndex)
            {

                case 0: this.chart1.Series[0].Points.Clear();
                    x = min;
                    while (x < max)
                    {
                        y = Math.Sin(x);
                        this.chart1.Series[0].Points.AddXY(x, y);
                        x += h;
                    }
                    break;
                case 1: this.chart1.Series[1].Points.Clear();
                    x = min;
                    while (x < max)
                    {
                        y = Math.Cos(x);
                        this.chart1.Series[1].Points.AddXY(x, y);
                        x += h;
                    }
                    break;
                case 2: this.chart1.Series[2].Points.Clear();
                    x = min;
                    while (x < max)
                    {
                        y = Math.Tan(x);
                        this.chart1.Series[2].Points.AddXY(x, y);
                        x += h;
                    }
                    break;
                case 3: this.chart1.Series[3].Points.Clear();
                    x = min;
                    while (x < max)
                    {
                        y = Math.Pow(x, 3);
                        this.chart1.Series[3].Points.AddXY(x, y);
                        x += h;
                    }
                    break;
                case 4: this.chart1.Series[4].Points.Clear();
                    x = min;
                    while (x < max)
                    {
                        y = Math.Sqrt(Math.Atan(x));
                        this.chart1.Series[4].Points.AddXY(x, y);
                        x += h;
                    }
                    break;
                case 5: this.chart1.Series[5].Points.Clear();
                    x = min;
                    while (x < max)
                    {
                        y = Math.Exp(x);
                        this.chart1.Series[5].Points.AddXY(x, y);
                        x += h;
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
