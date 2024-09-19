namespace Calci
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
            this.Display = new System.Windows.Forms.TextBox();
            this.n1 = new System.Windows.Forms.Button();
            this.n8 = new System.Windows.Forms.Button();
            this.n7 = new System.Windows.Forms.Button();
            this.n6 = new System.Windows.Forms.Button();
            this.n5 = new System.Windows.Forms.Button();
            this.n4 = new System.Windows.Forms.Button();
            this.n3 = new System.Windows.Forms.Button();
            this.n2 = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.ne = new System.Windows.Forms.Button();
            this.n0 = new System.Windows.Forms.Button();
            this.n9 = new System.Windows.Forms.Button();
            this.Sub = new System.Windows.Forms.Button();
            this.Mul = new System.Windows.Forms.Button();
            this.Div = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.nd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Display
            // 
            this.Display.Location = new System.Drawing.Point(147, 31);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(258, 22);
            this.Display.TabIndex = 0;
            this.Display.Text = "0";
            this.Display.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Display.TextChanged += new System.EventHandler(this.Display_TextChanged);
            // 
            // n1
            // 
            this.n1.Location = new System.Drawing.Point(147, 93);
            this.n1.Name = "n1";
            this.n1.Size = new System.Drawing.Size(45, 23);
            this.n1.TabIndex = 2;
            this.n1.Text = "1";
            this.n1.UseVisualStyleBackColor = true;
            this.n1.Click += new System.EventHandler(this.n1_Click);
            // 
            // n8
            // 
            this.n8.Location = new System.Drawing.Point(360, 155);
            this.n8.Name = "n8";
            this.n8.Size = new System.Drawing.Size(45, 23);
            this.n8.TabIndex = 3;
            this.n8.Text = "8";
            this.n8.UseVisualStyleBackColor = true;
            this.n8.Click += new System.EventHandler(this.n8_Click);
            // 
            // n7
            // 
            this.n7.Location = new System.Drawing.Point(287, 155);
            this.n7.Name = "n7";
            this.n7.Size = new System.Drawing.Size(45, 23);
            this.n7.TabIndex = 4;
            this.n7.Text = "7";
            this.n7.UseVisualStyleBackColor = true;
            this.n7.Click += new System.EventHandler(this.n7_Click);
            // 
            // n6
            // 
            this.n6.Location = new System.Drawing.Point(210, 155);
            this.n6.Name = "n6";
            this.n6.Size = new System.Drawing.Size(45, 23);
            this.n6.TabIndex = 5;
            this.n6.Text = "6";
            this.n6.UseVisualStyleBackColor = true;
            this.n6.Click += new System.EventHandler(this.n6_Click);
            // 
            // n5
            // 
            this.n5.Location = new System.Drawing.Point(147, 155);
            this.n5.Name = "n5";
            this.n5.Size = new System.Drawing.Size(45, 23);
            this.n5.TabIndex = 6;
            this.n5.Text = "5";
            this.n5.UseVisualStyleBackColor = true;
            this.n5.Click += new System.EventHandler(this.n5_Click);
            // 
            // n4
            // 
            this.n4.Location = new System.Drawing.Point(360, 93);
            this.n4.Name = "n4";
            this.n4.Size = new System.Drawing.Size(45, 23);
            this.n4.TabIndex = 7;
            this.n4.Text = "4";
            this.n4.UseVisualStyleBackColor = true;
            this.n4.Click += new System.EventHandler(this.n4_Click);
            // 
            // n3
            // 
            this.n3.Location = new System.Drawing.Point(287, 93);
            this.n3.Name = "n3";
            this.n3.Size = new System.Drawing.Size(45, 23);
            this.n3.TabIndex = 8;
            this.n3.Text = "3";
            this.n3.UseVisualStyleBackColor = true;
            this.n3.Click += new System.EventHandler(this.n3_Click);
            // 
            // n2
            // 
            this.n2.Location = new System.Drawing.Point(210, 93);
            this.n2.Name = "n2";
            this.n2.Size = new System.Drawing.Size(45, 23);
            this.n2.TabIndex = 9;
            this.n2.Text = "2";
            this.n2.UseVisualStyleBackColor = true;
            this.n2.Click += new System.EventHandler(this.n2_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(287, 214);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(45, 23);
            this.Add.TabIndex = 10;
            this.Add.Text = "+";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // ne
            // 
            this.ne.Location = new System.Drawing.Point(287, 280);
            this.ne.Name = "ne";
            this.ne.Size = new System.Drawing.Size(45, 23);
            this.ne.TabIndex = 11;
            this.ne.Text = "=";
            this.ne.UseVisualStyleBackColor = true;
            this.ne.Click += new System.EventHandler(this.ne_Click);
            // 
            // n0
            // 
            this.n0.Location = new System.Drawing.Point(210, 214);
            this.n0.Name = "n0";
            this.n0.Size = new System.Drawing.Size(45, 23);
            this.n0.TabIndex = 12;
            this.n0.Text = "0";
            this.n0.UseVisualStyleBackColor = true;
            this.n0.Click += new System.EventHandler(this.n0_Click);
            // 
            // n9
            // 
            this.n9.Location = new System.Drawing.Point(147, 214);
            this.n9.Name = "n9";
            this.n9.Size = new System.Drawing.Size(45, 23);
            this.n9.TabIndex = 13;
            this.n9.Text = "9";
            this.n9.UseVisualStyleBackColor = true;
            this.n9.Click += new System.EventHandler(this.n9_Click);
            // 
            // Sub
            // 
            this.Sub.Location = new System.Drawing.Point(360, 214);
            this.Sub.Name = "Sub";
            this.Sub.Size = new System.Drawing.Size(45, 23);
            this.Sub.TabIndex = 14;
            this.Sub.Text = "-";
            this.Sub.UseVisualStyleBackColor = true;
            this.Sub.Click += new System.EventHandler(this.Sub_Click);
            // 
            // Mul
            // 
            this.Mul.Location = new System.Drawing.Point(147, 280);
            this.Mul.Name = "Mul";
            this.Mul.Size = new System.Drawing.Size(45, 23);
            this.Mul.TabIndex = 15;
            this.Mul.Text = "*";
            this.Mul.UseVisualStyleBackColor = true;
            this.Mul.Click += new System.EventHandler(this.Mul_Click);
            // 
            // Div
            // 
            this.Div.Location = new System.Drawing.Point(210, 280);
            this.Div.Name = "Div";
            this.Div.Size = new System.Drawing.Size(45, 23);
            this.Div.TabIndex = 16;
            this.Div.Text = "/";
            this.Div.UseVisualStyleBackColor = true;
            this.Div.Click += new System.EventHandler(this.Div_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(250, 338);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(45, 23);
            this.Clear.TabIndex = 17;
            this.Clear.Text = "C";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // nd
            // 
            this.nd.Location = new System.Drawing.Point(360, 280);
            this.nd.Name = "nd";
            this.nd.Size = new System.Drawing.Size(45, 23);
            this.nd.TabIndex = 18;
            this.nd.Text = ".";
            this.nd.UseVisualStyleBackColor = true;
            this.nd.Click += new System.EventHandler(this.nd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nd);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Div);
            this.Controls.Add(this.Mul);
            this.Controls.Add(this.Sub);
            this.Controls.Add(this.n9);
            this.Controls.Add(this.n0);
            this.Controls.Add(this.ne);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.n2);
            this.Controls.Add(this.n3);
            this.Controls.Add(this.n4);
            this.Controls.Add(this.n5);
            this.Controls.Add(this.n6);
            this.Controls.Add(this.n7);
            this.Controls.Add(this.n8);
            this.Controls.Add(this.n1);
            this.Controls.Add(this.Display);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Display;
        private System.Windows.Forms.Button n1;
        private System.Windows.Forms.Button n8;
        private System.Windows.Forms.Button n7;
        private System.Windows.Forms.Button n6;
        private System.Windows.Forms.Button n5;
        private System.Windows.Forms.Button n4;
        private System.Windows.Forms.Button n3;
        private System.Windows.Forms.Button n2;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button ne;
        private System.Windows.Forms.Button n0;
        private System.Windows.Forms.Button n9;
        private System.Windows.Forms.Button Sub;
        private System.Windows.Forms.Button Mul;
        private System.Windows.Forms.Button Div;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button nd;
    }
}

