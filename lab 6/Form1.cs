using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_6
{
    public partial class Form1 : Form
    {
        public double a;
        public double b;
        public double c;
        public double x;
        public double y;
        public double A;
        public double B;
        public double h = 0.1;
        public double selected_x;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false && radioButton4.Checked == false && radioButton5.Checked == false && radioButton6.Checked == false && radioButton7.Checked == false && radioButton8.Checked == false)
            {
                MessageBox.Show("Выберите функцию");
                return;
            }
            else if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox6.Text == "" || textBox7.Text == "")
            {
                MessageBox.Show("Введите всё значения");
                return;
            }
            else
            {
                a = Convert.ToDouble(textBox1.Text);
                b = Convert.ToDouble(textBox2.Text);
                c = Convert.ToDouble(textBox3.Text);
                x = Convert.ToDouble(textBox4.Text);
                A = Convert.ToDouble(textBox6.Text);
                B = Convert.ToDouble(textBox7.Text);     
            }
            if (radioButton1.Checked)
            {
                selected_x = x;
                x = A;
                this.chart1.Series[0].Points.Clear();
                this.chart1.Series[1].Points.Clear();
                while (x <= B)
                {
                    y = x * a + b;
                    this.chart1.Series[0].Points.AddXY(x, y);
                    if (selected_x == Math.Round(x,2))
                    {
                        this.chart1.Series[1].Points.AddXY(selected_x, y);
                    }
                    x = x + h;
                }
            }
            if (radioButton2.Checked)
            {
                selected_x = x;
                x = A;
                this.chart1.Series[0].Points.Clear();
                this.chart1.Series[1].Points.Clear();
                while (x <= B)
                {
                    y = a * Math.Sin(x * b) + c;
                    this.chart1.Series[0].Points.AddXY(x, y);
                    if (selected_x == Math.Round(x, 2))
                    {
                        this.chart1.Series[1].Points.AddXY(selected_x, y);
                    }
                    x = x + h;
                }
            }
            if (radioButton3.Checked)
            {
                selected_x = x;
                x = A;
                this.chart1.Series[0].Points.Clear();
                this.chart1.Series[1].Points.Clear();
                while (x <= B)
                {
                    y = a * Math.Cos(x * b + c);
                    this.chart1.Series[0].Points.AddXY(x, y);
                    if (selected_x == Math.Round(x, 2))
                    {
                        this.chart1.Series[1].Points.AddXY(selected_x, y);
                    }
                    x = x + h;
                }
            }
            if (radioButton4.Checked)
            {
                selected_x = x;
                x = A;
                this.chart1.Series[0].Points.Clear();
                this.chart1.Series[1].Points.Clear();
                while (x <= B)
                {
                    y = a * Math.Tan(x * b) + c;
                    this.chart1.Series[0].Points.AddXY(x, y);
                    if (selected_x == Math.Round(x, 2))
                    {
                        this.chart1.Series[1].Points.AddXY(selected_x, y);
                    }
                    x = x + h;
                }
            }
            if (radioButton5.Checked)
            {
                selected_x = x;
                x = A;
                this.chart1.Series[0].Points.Clear();
                this.chart1.Series[1].Points.Clear();
                while (x <= B)
                {
                    y = a * (1 / (Math.Tan(x * b + c)));
                    this.chart1.Series[0].Points.AddXY(x, y);
                    if (selected_x == Math.Round(x, 2))
                    {
                        this.chart1.Series[1].Points.AddXY(selected_x, y);
                    }
                    x = x + h;
                }
            }
            if (radioButton6.Checked)
            {
                selected_x = x;
                x = A;
                this.chart1.Series[0].Points.Clear();
                this.chart1.Series[1].Points.Clear();
                while (x <= B)
                {
                    y = b * Math.Pow(x, a);
                    this.chart1.Series[0].Points.AddXY(x, y);
                    if (selected_x == Math.Round(x, 2))
                    {
                        this.chart1.Series[1].Points.AddXY(selected_x, y);
                    }
                    x = x + h;
                }
            }
            if (radioButton7.Checked)
            {
                selected_x = x;
                x = A;
                this.chart1.Series[0].Points.Clear();
                this.chart1.Series[1].Points.Clear();
                while (x <= B)
                {
                    y = Math.Pow(a, x + b);
                    this.chart1.Series[0].Points.AddXY(x, y);
                    if (selected_x == Math.Round(x, 2))
                    {
                        this.chart1.Series[1].Points.AddXY(selected_x, y);
                    }
                    x = x + h;
                }
            }
            if (radioButton8.Checked)
            {
                selected_x = x;
                x = A;
                this.chart1.Series[0].Points.Clear();
                this.chart1.Series[1].Points.Clear();
                while (x <= B)
                {
                    y = Math.Pow(((Math.Sin(x) + a * x) / ((x - Math.Pow(x, 0.5)) + 1)), b / x);
                    this.chart1.Series[0].Points.AddXY(x, y);
                    if (selected_x == Math.Round(x, 2))
                    {
                        this.chart1.Series[1].Points.AddXY(selected_x, y);
                    }
                    x = x + h;
                }
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
