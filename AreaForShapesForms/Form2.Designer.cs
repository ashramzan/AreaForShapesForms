namespace AreaForShapesForms
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.labelAreaCircle = new System.Windows.Forms.Label();
            this.labelPerimeterCircle = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ToForm3 = new System.Windows.Forms.Button();
            this.ToForm1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(308, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Area and Perimeter of a  Circle";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(399, 119);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(260, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter the radius";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(345, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelAreaCircle
            // 
            this.labelAreaCircle.AutoSize = true;
            this.labelAreaCircle.Location = new System.Drawing.Point(260, 266);
            this.labelAreaCircle.Name = "labelAreaCircle";
            this.labelAreaCircle.Size = new System.Drawing.Size(45, 13);
            this.labelAreaCircle.TabIndex = 4;
            this.labelAreaCircle.Text = "Area is: ";
            // 
            // labelPerimeterCircle
            // 
            this.labelPerimeterCircle.AutoSize = true;
            this.labelPerimeterCircle.Location = new System.Drawing.Point(447, 266);
            this.labelPerimeterCircle.Name = "labelPerimeterCircle";
            this.labelPerimeterCircle.Size = new System.Drawing.Size(64, 13);
            this.labelPerimeterCircle.TabIndex = 5;
            this.labelPerimeterCircle.Text = "Perimeter is:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Try:";
            // 
            // ToForm3
            // 
            this.ToForm3.Location = new System.Drawing.Point(15, 110);
            this.ToForm3.Name = "ToForm3";
            this.ToForm3.Size = new System.Drawing.Size(75, 23);
            this.ToForm3.TabIndex = 12;
            this.ToForm3.Text = "Triangle";
            this.ToForm3.UseVisualStyleBackColor = true;
            this.ToForm3.Click += new System.EventHandler(this.ToForm3_Click);
            // 
            // ToForm1
            // 
            this.ToForm1.Location = new System.Drawing.Point(15, 80);
            this.ToForm1.Name = "ToForm1";
            this.ToForm1.Size = new System.Drawing.Size(75, 23);
            this.ToForm1.TabIndex = 11;
            this.ToForm1.Text = "Square";
            this.ToForm1.UseVisualStyleBackColor = true;
            this.ToForm1.Click += new System.EventHandler(this.ToForm2_Click);
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(761, 403);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ToForm3);
            this.Controls.Add(this.ToForm1);
            this.Controls.Add(this.labelPerimeterCircle);
            this.Controls.Add(this.labelAreaCircle);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Name = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelAreaCircle;
        private System.Windows.Forms.Label labelPerimeterCircle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ToForm3;
        private System.Windows.Forms.Button ToForm1;
    }
}