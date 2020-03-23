namespace Calculadora
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
            this.one = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.dec = new System.Windows.Forms.Button();
            this.modulo = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.mult = new System.Windows.Forms.Button();
            this.sub = new System.Windows.Forms.Button();
            this.sum = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.TextBox();
            this.equation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // one
            // 
            this.one.Location = new System.Drawing.Point(41, 225);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(50, 50);
            this.one.TabIndex = 0;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.button_Click);
            // 
            // two
            // 
            this.two.Location = new System.Drawing.Point(97, 225);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(50, 50);
            this.two.TabIndex = 1;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.button_Click);
            // 
            // three
            // 
            this.three.Location = new System.Drawing.Point(153, 225);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(50, 50);
            this.three.TabIndex = 2;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.button_Click);
            // 
            // four
            // 
            this.four.Location = new System.Drawing.Point(41, 169);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(50, 50);
            this.four.TabIndex = 3;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.button_Click);
            // 
            // five
            // 
            this.five.Location = new System.Drawing.Point(97, 169);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(50, 50);
            this.five.TabIndex = 4;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.button_Click);
            // 
            // six
            // 
            this.six.Location = new System.Drawing.Point(153, 169);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(50, 50);
            this.six.TabIndex = 5;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.button_Click);
            // 
            // seven
            // 
            this.seven.Location = new System.Drawing.Point(41, 113);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(50, 50);
            this.seven.TabIndex = 6;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.button_Click);
            // 
            // eight
            // 
            this.eight.Location = new System.Drawing.Point(97, 113);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(50, 50);
            this.eight.TabIndex = 7;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.button_Click);
            // 
            // nine
            // 
            this.nine.Location = new System.Drawing.Point(153, 113);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(50, 50);
            this.nine.TabIndex = 8;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.button_Click);
            // 
            // zero
            // 
            this.zero.Location = new System.Drawing.Point(41, 281);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(106, 50);
            this.zero.TabIndex = 9;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.button_Click);
            // 
            // dec
            // 
            this.dec.Location = new System.Drawing.Point(153, 281);
            this.dec.Name = "dec";
            this.dec.Size = new System.Drawing.Size(50, 50);
            this.dec.TabIndex = 10;
            this.dec.Text = ".";
            this.dec.UseVisualStyleBackColor = true;
            this.dec.Click += new System.EventHandler(this.button_Click);
            // 
            // modulo
            // 
            this.modulo.Location = new System.Drawing.Point(209, 113);
            this.modulo.Name = "modulo";
            this.modulo.Size = new System.Drawing.Size(78, 41);
            this.modulo.TabIndex = 11;
            this.modulo.Text = "%";
            this.modulo.UseVisualStyleBackColor = true;
            this.modulo.Click += new System.EventHandler(this.operator_Click);
            // 
            // div
            // 
            this.div.Location = new System.Drawing.Point(209, 156);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(78, 41);
            this.div.TabIndex = 12;
            this.div.Text = "/";
            this.div.UseVisualStyleBackColor = true;
            this.div.Click += new System.EventHandler(this.operator_Click);
            // 
            // mult
            // 
            this.mult.Location = new System.Drawing.Point(209, 201);
            this.mult.Name = "mult";
            this.mult.Size = new System.Drawing.Size(78, 41);
            this.mult.TabIndex = 13;
            this.mult.Text = "*";
            this.mult.UseVisualStyleBackColor = true;
            this.mult.Click += new System.EventHandler(this.operator_Click);
            // 
            // sub
            // 
            this.sub.Location = new System.Drawing.Point(209, 245);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(78, 41);
            this.sub.TabIndex = 14;
            this.sub.Text = "-";
            this.sub.UseVisualStyleBackColor = true;
            this.sub.Click += new System.EventHandler(this.operator_Click);
            // 
            // sum
            // 
            this.sum.Location = new System.Drawing.Point(209, 290);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(78, 41);
            this.sum.TabIndex = 15;
            this.sum.Text = "+";
            this.sum.UseVisualStyleBackColor = true;
            this.sum.Click += new System.EventHandler(this.operator_Click);
            // 
            // equal
            // 
            this.equal.Location = new System.Drawing.Point(293, 225);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(50, 106);
            this.equal.TabIndex = 20;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = true;
            this.equal.Click += new System.EventHandler(this.button17_Click);
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(293, 169);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(50, 50);
            this.button18.TabIndex = 21;
            this.button18.Text = "C";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(293, 113);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(50, 50);
            this.button19.TabIndex = 22;
            this.button19.Text = "CE";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // result
            // 
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.Location = new System.Drawing.Point(41, 47);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(302, 35);
            this.result.TabIndex = 23;
            this.result.Text = "0";
            this.result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // equation
            // 
            this.equation.AutoSize = true;
            this.equation.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.equation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equation.Location = new System.Drawing.Point(50, 53);
            this.equation.Name = "equation";
            this.equation.Size = new System.Drawing.Size(0, 22);
            this.equation.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 387);
            this.Controls.Add(this.equation);
            this.Controls.Add(this.result);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.mult);
            this.Controls.Add(this.div);
            this.Controls.Add(this.modulo);
            this.Controls.Add(this.dec);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.six);
            this.Controls.Add(this.five);
            this.Controls.Add(this.four);
            this.Controls.Add(this.three);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(405, 443);
            this.MinimumSize = new System.Drawing.Size(405, 443);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button dec;
        private System.Windows.Forms.Button modulo;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.Button mult;
        private System.Windows.Forms.Button sub;
        private System.Windows.Forms.Button sum;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Label equation;
    }
}

