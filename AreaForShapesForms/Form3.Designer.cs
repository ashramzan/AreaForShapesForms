﻿namespace AreaForShapesForms
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelAreaTriangle = new System.Windows.Forms.Label();
            this.labelPerimeterTriangle = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ToForm2 = new System.Windows.Forms.Button();
            this.ToForm1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(320, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Area and Perimeter of a Triangle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter side 1 ";
            // 
            // labelAreaTriangle
            // 
            this.labelAreaTriangle.AutoSize = true;
            this.labelAreaTriangle.Location = new System.Drawing.Point(261, 312);
            this.labelAreaTriangle.Name = "labelAreaTriangle";
            this.labelAreaTriangle.Size = new System.Drawing.Size(45, 13);
            this.labelAreaTriangle.TabIndex = 3;
            this.labelAreaTriangle.Text = "Area is: ";
            // 
            // labelPerimeterTriangle
            // 
            this.labelPerimeterTriangle.AutoSize = true;
            this.labelPerimeterTriangle.Location = new System.Drawing.Point(474, 312);
            this.labelPerimeterTriangle.Name = "labelPerimeterTriangle";
            this.labelPerimeterTriangle.Size = new System.Drawing.Size(64, 13);
            this.labelPerimeterTriangle.TabIndex = 4;
            this.labelPerimeterTriangle.Text = "Perimeter is:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(362, 239);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(175, 149);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(346, 149);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(529, 149);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(359, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Enter side 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(545, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Enter side 3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Try:";
            // 
            // ToForm2
            // 
            this.ToForm2.Location = new System.Drawing.Point(15, 119);
            this.ToForm2.Name = "ToForm2";
            this.ToForm2.Size = new System.Drawing.Size(75, 23);
            this.ToForm2.TabIndex = 15;
            this.ToForm2.Text = "Circle";
            this.ToForm2.UseVisualStyleBackColor = true;
            this.ToForm2.Click += new System.EventHandler(this.ToForm2_Click);
            // 
            // ToForm1
            // 
            this.ToForm1.Location = new System.Drawing.Point(15, 89);
            this.ToForm1.Name = "ToForm1";
            this.ToForm1.Size = new System.Drawing.Size(75, 23);
            this.ToForm1.TabIndex = 14;
            this.ToForm1.Text = "Square";
            this.ToForm1.UseVisualStyleBackColor = true;
            this.ToForm1.Click += new System.EventHandler(this.ToForm1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ToForm2);
            this.Controls.Add(this.ToForm1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.labelPerimeterTriangle);
            this.Controls.Add(this.labelAreaTriangle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelAreaTriangle;
        private System.Windows.Forms.Label labelPerimeterTriangle;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ToForm2;
        private System.Windows.Forms.Button ToForm1;
    }
}