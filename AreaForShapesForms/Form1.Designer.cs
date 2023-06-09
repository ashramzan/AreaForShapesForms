namespace AreaForShapesForms
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.titleRectangle = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelArea = new System.Windows.Forms.Label();
            this.labelPerimeter = new System.Windows.Forms.Label();
            this.ToForm2 = new System.Windows.Forms.Button();
            this.ToForm3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(400, 146);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(400, 186);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // titleRectangle
            // 
            this.titleRectangle.AutoSize = true;
            this.titleRectangle.Location = new System.Drawing.Point(309, 48);
            this.titleRectangle.Name = "titleRectangle";
            this.titleRectangle.Size = new System.Drawing.Size(170, 13);
            this.titleRectangle.TabIndex = 2;
            this.titleRectangle.Text = "Area and Perimeter of a Rectangle";
            this.titleRectangle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.titleRectangle.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(351, 248);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(289, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter length";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Enter width";
            // 
            // labelArea
            // 
            this.labelArea.AutoSize = true;
            this.labelArea.Location = new System.Drawing.Point(262, 309);
            this.labelArea.Name = "labelArea";
            this.labelArea.Size = new System.Drawing.Size(45, 13);
            this.labelArea.TabIndex = 6;
            this.labelArea.Text = "Area is: ";
            // 
            // labelPerimeter
            // 
            this.labelPerimeter.AutoSize = true;
            this.labelPerimeter.Location = new System.Drawing.Point(467, 309);
            this.labelPerimeter.Name = "labelPerimeter";
            this.labelPerimeter.Size = new System.Drawing.Size(67, 13);
            this.labelPerimeter.TabIndex = 7;
            this.labelPerimeter.Text = "Perimeter is: ";
            // 
            // ToForm2
            // 
            this.ToForm2.Location = new System.Drawing.Point(22, 80);
            this.ToForm2.Name = "ToForm2";
            this.ToForm2.Size = new System.Drawing.Size(75, 23);
            this.ToForm2.TabIndex = 8;
            this.ToForm2.Text = "Circle";
            this.ToForm2.UseVisualStyleBackColor = true;
            this.ToForm2.Click += new System.EventHandler(this.ToForm2_Click);
            // 
            // ToForm3
            // 
            this.ToForm3.Location = new System.Drawing.Point(22, 110);
            this.ToForm3.Name = "ToForm3";
            this.ToForm3.Size = new System.Drawing.Size(75, 23);
            this.ToForm3.TabIndex = 9;
            this.ToForm3.Text = "Triangle";
            this.ToForm3.UseVisualStyleBackColor = true;
            this.ToForm3.Click += new System.EventHandler(this.ToForm3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Try:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ToForm3);
            this.Controls.Add(this.ToForm2);
            this.Controls.Add(this.labelPerimeter);
            this.Controls.Add(this.labelArea);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.titleRectangle);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label titleRectangle;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelArea;
        private System.Windows.Forms.Label labelPerimeter;
        private System.Windows.Forms.Button ToForm2;
        private System.Windows.Forms.Button ToForm3;
        private System.Windows.Forms.Label label3;
    }
}

