
namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Num1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Mygtukas2 = new System.Windows.Forms.Button();
            this.Num2 = new System.Windows.Forms.TextBox();
            this.Eglute = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Įveskite skaičių:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(477, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(295, 102);
            this.button1.TabIndex = 1;
            this.button1.Text = "Skaičiuoti";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Num1
            // 
            this.Num1.Location = new System.Drawing.Point(200, 83);
            this.Num1.Name = "Num1";
            this.Num1.Size = new System.Drawing.Size(176, 27);
            this.Num1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(25, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Įveskite eglutės aukštį:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Mygtukas2
            // 
            this.Mygtukas2.Location = new System.Drawing.Point(472, 259);
            this.Mygtukas2.Name = "Mygtukas2";
            this.Mygtukas2.Size = new System.Drawing.Size(300, 97);
            this.Mygtukas2.TabIndex = 4;
            this.Mygtukas2.Text = "Skaičiuoti";
            this.Mygtukas2.UseVisualStyleBackColor = true;
            this.Mygtukas2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Num2
            // 
            this.Num2.Location = new System.Drawing.Point(264, 263);
            this.Num2.Name = "Num2";
            this.Num2.Size = new System.Drawing.Size(171, 27);
            this.Num2.TabIndex = 5;
            this.Num2.TextChanged += new System.EventHandler(this.Num2_TextChanged);
            // 
            // Eglute
            // 
            this.Eglute.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Eglute.Location = new System.Drawing.Point(75, 332);
            this.Eglute.Name = "Eglute";
            this.Eglute.Size = new System.Drawing.Size(324, 308);
            this.Eglute.TabIndex = 6;
            this.Eglute.Text = "";
            this.Eglute.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Informacija";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(124, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(200, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 9;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(411, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 20);
            this.label6.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 686);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Eglute);
            this.Controls.Add(this.Num2);
            this.Controls.Add(this.Mygtukas2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Num1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Mantas Riepšas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Num1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Mygtukas2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox Eglute;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Num2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

