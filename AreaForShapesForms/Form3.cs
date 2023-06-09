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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            double side1 = Convert.ToDouble(textBox1.Text);
            double side2 = Convert.ToDouble(textBox2.Text);
            double side3 = Convert.ToDouble(textBox3.Text);

            double s = (side1 + side2 + side3) / 2;
            double area = Math.Sqrt(s * (s-side1) * (s-side2) * (s-side3));
            double perimeter = side1 + side2 + side3;

            if (area > 0) {
                labelAreaTriangle.Text = $"Area is: {area}";
                labelPerimeterTriangle.Text = $"Perimeter is: {perimeter}";
            }
            else
            {
                labelAreaTriangle.Text = $"This is not a practical Triangle.";
                labelPerimeterTriangle.Text = string.Empty;
            }
        }

        private void ToForm1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Close();
        }

        private void ToForm2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
            this.Close();
        }
    }
}
