using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        /* Globalūs kintamieji */
        int []Xskaiciai = new int [10];
        int Xkiekis = 1;
        int kiekis = 0;
        /***********************/

        private void button1_Click(object sender, EventArgs e)
        {
            int suma = 0;

            if ( kiekis < 10)
            {
                Xskaiciai[kiekis] = Convert.ToInt16(Num1.Text);
                label3.Text = Convert.ToString("Įvestas skaičius:");
                label4.Text = Convert.ToString( Xskaiciai[kiekis]);
                label5.Text = Convert.ToString("Įveskite daugiau skaičių, įvesta:");
                label6.Text = Convert.ToString(Xkiekis);
                Xkiekis++;
                kiekis++;
            }
            if (kiekis == 10)
            {
                for (int i = 0; i < 10; i++)
                {
                    suma = suma + Xskaiciai[i];
                }
                label3.Text = Convert.ToString("Skaičių suma:");
                label4.Text = Convert.ToString(suma);
                /*Pakeičiami globalūs kintamieji į savo pradinę reikšmę, kad vartotojas galėtų išnaujo atlikti šį veiksmą.*/
                Array.Clear(Xskaiciai, 0, Xskaiciai.Length);
                Xkiekis = 1;
                kiekis = 0;
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        /***********************************************************/
                               /* Eglutė */
        private void button2_Click(object sender, EventArgs e)
        {
            Eglute.Clear();
            int h;
            h = Convert.ToInt16(Num2.Text);

            int plotis = h;
            int eglutis = 1;

            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < plotis; j++)
                {
                    Eglute.AppendText(" ");
                }
                for (int j = 0; j < eglutis; j++)
                {
                    Eglute.SelectionColor = Color.Green;
                    Eglute.AppendText(" * ");
                }
                Eglute.AppendText("\n");
                eglutis++;
                plotis --;
            }
            Eglute.AppendText("\n");
        }
        /*************************************************************/

        private void Num2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
