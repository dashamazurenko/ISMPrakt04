using LibraryPrakt04;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISMPrakt04
{
    public partial class Form1 : Form
    {
        static int flac = 0;
        public Form1()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            flac = 1;
            labelA.Visible = true;
            labelB.Visible = true;
            richTextBox1.Visible = true;
            textBoxB.Visible = true;
            //int a = int.Parse(richTextBox1.Text);
            //int b = int.Parse(textBoxB.Text);
            //int result = LibraryPrakt04.Class1.DobFromAtoB(a, b);
            //textBoxRes.Text = $"{result}";
            textBoxRes.Visible = true;
            labelRes.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            flac = 4;
            labelA.Visible = true;
            labelB.Visible = true;
            labelName.Visible = true;
            richTextBox1.Visible = true;
            textBoxB.Visible = true;
            //double a = double.Parse(richTextBox1.Text);
            //double b = double.Parse(textBoxB.Text);
            //double result = LibraryPrakt04.Class1.SumaKv(a, b);
            //textBoxRes.Text = $"{result}";
            //labelName.Visible = true;
            //textBoxRes.Visible = true;
            //labelRes.Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            flac = 8;
            labelP.Visible = true;
            textBoxP.Visible = true;
            //double p = double.Parse(richTextBox1.Text);
            //double summa = 0;
            //double k = 1;
            //double result = LibraryPrakt04.Class1.SumaDniv(out summa, out k, p);
            //textBoxRes.Text = $"{summa}";
            //textBoxB.Text = $"{k}";
            //labelName.Visible = true;
            //textBoxRes.Visible = true;
            //labelRes.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            flac = 2;
            labelA.Visible = true;
            labelName.Visible = true;
            richTextBox1.Visible = true;
            //int a = int.Parse(richTextBox1.Text);
            //float result = LibraryPrakt04.Class1.Suma(a);
            //textBoxRes.Text = $"{result}";
            //labelName.Visible = true;
            //textBoxRes.Visible = true;
            //labelRes.Visible = true;
        }

        private void labelName_Click(object sender, EventArgs e)
        {

        }

        private void textBoxA_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            flac = 3;
            labelA.Visible = true;
            labelB.Visible = true;
            labelName.Visible = true;
            richTextBox1.Visible = true;
            textBoxB.Visible = true;
            //double a = double.Parse(richTextBox1.Text);
            //int b = int.Parse(textBoxB.Text);
            //double result = LibraryPrakt04.Class1.Stepin(a, b);
            //textBoxRes.Text = $"{result}";
            //labelName.Visible = true;
            //textBoxRes.Visible = true;
            //labelRes.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            flac = 5;
            labelA.Visible = true;
            labelName.Visible = true;
            richTextBox1.Visible = true;
            //double a = double.Parse(richTextBox1.Text);
            //double result = LibraryPrakt04.Class1.Suma5(a);
            //textBoxRes.Text = $"{result}";
            //labelName.Visible = true;
            //textBoxRes.Visible = true;
            //labelRes.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            flac = 6;
            labelA.Visible = true;
            labelName.Visible = true;
            richTextBox1.Visible = true;
            //double a = double.Parse(richTextBox1.Text);
            //double result = LibraryPrakt04.Class1.SumaWhile1(a);
            //textBoxRes.Text = $"{result}";
            //labelName.Visible = true;
            //textBoxRes.Visible = true;
            //labelRes.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            flac = 7;
            labelA.Visible = true;
            labelName.Visible = true;
            richTextBox1.Visible = true;
            //int k = 0;
            //double a = double.Parse(richTextBox1.Text);
            //double result = LibraryPrakt04.Class1.MinCile(k, a);
            //textBoxRes.Text = $"{result}";
            //labelName.Visible = true;
            //textBoxRes.Visible = true;
            //labelRes.Visible = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            flac = 9;
            labelA.Visible = true;
            labelName.Visible = true;
            richTextBox1.Visible = true;
            //string[] arr = richTextBox1.Text.Split('\n');
            //int summa = 0;
            //double result = LibraryPrakt04.Class1.SumaDoWhile(summa, arr);
            //textBoxRes.Text = $"{result}";
            //labelName.Visible = true;
            //textBoxRes.Visible = true;
            //labelRes.Visible = true;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            
            switch (flac)
            {
                case 1:
                    int a = int.Parse(richTextBox1.Text);
                    int b = int.Parse(textBoxB.Text);
                    int result = LibraryPrakt04.Class1.DobFromAtoB(a, b);
                    textBoxRes.Text = $"{result}";
                    textBoxRes.Visible = true;
                    labelRes.Visible = true;
                    labelName.Visible = true;
                    break;
                case 2:

                    int c = int.Parse(richTextBox1.Text);
                    float res = LibraryPrakt04.Class1.Suma(c);
                    textBoxRes.Text = $"{res}";
                    labelName.Visible = true;
                    textBoxRes.Visible = true;
                    labelRes.Visible = true;
                    break;
                case 3:

                    double d = double.Parse(richTextBox1.Text);
                    int z = int.Parse(textBoxB.Text);
                    double result3 = LibraryPrakt04.Class1.Stepin(d, z);
                    textBoxRes.Text = $"{result3}";
                    labelName.Visible = true;
                    textBoxRes.Visible = true;
                    labelRes.Visible = true;
                    break;
                case 4:

                    double i = double.Parse(richTextBox1.Text);
                    double q = double.Parse(textBoxB.Text);
                    double result4 = LibraryPrakt04.Class1.SumaKv(i, q);
                    textBoxRes.Text = $"{result4}";
                    labelName.Visible = true;
                    textBoxRes.Visible = true;
                    labelRes.Visible = true;
                    break;
                case 5:

                    double w = double.Parse(richTextBox1.Text);
                    double result5 = LibraryPrakt04.Class1.Factorial(w);
                    textBoxRes.Text = $"{result5}";
                    labelName.Visible = true;
                    textBoxRes.Visible = true;
                    labelRes.Visible = true;
                    break;
                case 6:

                    double v = double.Parse(richTextBox1.Text);
                    double result6 = LibraryPrakt04.Class1.SumaWhile1(v);
                    textBoxRes.Text = $"{result6}";
                    labelName.Visible = true;
                    textBoxRes.Visible = true;
                    labelRes.Visible = true;
                    break;
                case 7:

                    int k = 0;
                    double o = double.Parse(richTextBox1.Text);
                    double result7 = LibraryPrakt04.Class1.MinCile(k, o);
                    textBoxRes.Text = $"{result7}";
                    labelName.Visible = true;
                    textBoxRes.Visible = true;
                    labelRes.Visible = true;
                    break;
                case 8:

                    double p = double.Parse(textBoxP.Text);
                    double summa = 0;
                    double u = 1;
                    double result8 = LibraryPrakt04.Class1.SumaDniv(out summa, out u, p);
                    textBoxRes.Text = $"{summa}";
                    textBoxB.Text = $"{u}";
                    labelName.Visible = true;
                    textBoxRes.Visible = true;
                    labelRes.Visible = true;
                    break;
                case 9:

                    string[] arr = richTextBox1.Text.Split('\n');
                    int suma = 0;
                    double result9 = LibraryPrakt04.Class1.SumaDoWhile(suma, arr);
                    textBoxRes.Text = $"{result9}";
                    labelName.Visible = true;
                    textBoxRes.Visible = true;
                    labelRes.Visible = true;
                    break;

            }
            labelA.Visible = false;
            labelB.Visible = false;
            textBoxB.Visible = false;
            textBoxB.Clear();
            richTextBox1.Clear();
            textBoxP.Clear();
            richTextBox1.Visible = false;
            labelP.Visible = false;
            textBoxP.Visible = false;
        }

        private void labelP_Click(object sender, EventArgs e)
        {

        }

        
    }
}
