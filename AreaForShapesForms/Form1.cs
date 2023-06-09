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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            double length = Convert.ToDouble(textBox1.Text);
            double width = Convert.ToDouble(textBox2.Text);

            double area = length * width;
            double perimeter = (length * 2) + (width * 2);

            labelArea.Text = $"Area is: {area}";
            labelPerimeter.Text = $"Perimeter is: {perimeter}";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ToForm2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
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
