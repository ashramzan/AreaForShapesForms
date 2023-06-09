using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreaForShapesForms
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double pi = Math.PI;
            double radius = Convert.ToDouble(textBox1.Text);
            double area = pi * (radius * radius);
            double perimeter =  2 * pi * radius;
            labelAreaCircle.Text = $"Area is: {area}";
            labelPerimeterCircle.Text = $"Perimeter is: {perimeter}";
        }

        private void ToForm2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Close();
        }

        private void ToForm3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
            this.Close();
        }
    }
}
