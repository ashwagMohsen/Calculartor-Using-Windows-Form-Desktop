using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc
{
    public partial class Form1 : Form
    {
        double f;
        double s;
        double a;
        string op;
        Int64 n;
        public Form1()
        {
            InitializeComponent();
        }
        //int c = 1;
        private void button_Click(object sender, EventArgs e)
        {
            //string spath;
            //System.Media.SoundPlayer mySound;
            //spath = "D:\\1.mp3";
            //mySound = new System.Media.SoundPlayer(spath);
            //mySound.Play();

            //Control ctrl = ((Control)sender);
            //if (c==1)
            //{

            //    ctrl.BackColor = Color.Black;
            //    c += 1;
            //}
            //else
            //{
            //    ctrl.BackColor = Color.White;
            //    c -= 1;
            //}
            Button b = sender as Button;
            if (label1.Text == "0") {
                label1.Text = b.Text;
            }
            else
            {
                label1.Text = label1.Text + b.Text;
            }

        }

        private void button16_Click(object sender, EventArgs e)
        {
            s =Convert.ToDouble( label1.Text);
            if (op == "+")
            {
                a = f + s;
                label1.Text =Convert.ToString( a);
                label2.Text = "";

            }
            else if(op=="-"){
                a = f - s;
                label1.Text = Convert.ToString(a);
                label2.Text = "";
            }
            else if (op == "/")
            {
                a = f / s;
                label1.Text = Convert.ToString(a);
                label2.Text = "";
            }
            else if (op == "x")
            {
                a = f * s;
                label1.Text = Convert.ToString(a);
                label2.Text = "";
            }
            else if (op == "mod")
            {
                //mod here mean out of division
                a = f % s;
                label1.Text = Convert.ToString(a);
                label2.Text = "";
            }
            else if (op == "exp")
            {
                a = Math.Pow( f , s);
                label1.Text = Convert.ToString(a);
                label2.Text = "";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
            label2.Text = "";

        }

        private void arithmetic_functions(object sender, EventArgs e)
        {
            //Boolean ii = false;
            //// if((label2.Text).Contains("x") || (label2.Text).Contains("/")|| (label2.Text).Contains("+")|| (label2.Text).Contains("-"))

            //foreach (char i in label2.Text)
            //{
            //    ii = true;
            //    if(i== 'x' || i == '/' || i == '+' || i == '-')
            //    {
            //        s = Convert.ToDouble(label1.Text);
            //        if (op == "+")
            //        {
            //            a = f + s;
            //            label2.Text = Convert.ToString(a);
            //           // label2.Text = "";

            //        }
            //        else if (op == "-")
            //        {
            //            a = f - s;
            //            label2.Text = Convert.ToString(a);
            //           // label2.Text = "";
            //        }
            //        else if (op == "/")
            //        {
            //            a = f / s;
            //            label2.Text = Convert.ToString(a);
            //          //  label2.Text = "";
            //        }
            //        else if (op == "x")
            //        {
            //            a = f * s;
            //            label2.Text = Convert.ToString(a);
            //           // label2.Text = "";
            //        }
            //        else if (op == "mod")
            //        {
            //            //mod here mean out of division
            //            a = f % s;
            //            label2.Text = Convert.ToString(a);
            //           // label2.Text = "";
            //        }
            //        else if (op == "exp")
            //        {
            //            a = Math.Pow(f, s);
            //            label2.Text = Convert.ToString(a);
            //          //  label2.Text = "";
            //        }
            //        Button ops = sender as Button;
            //        //number in lble1 store it in a variable 
            //        f = Convert.ToDouble(label1.Text);
            //        //and put this num in label2
            //        // label2.Text = label1.Text;
            //        //and make label1 be empty
            //        label1.Text = "";
            //        //this operator thhat I clicked store it in op var
            //        op = ops.Text;
            //        label2.Text = label2.Text + "" + op;
            //        break;
            //    }
            //    else
            //    {
            //        Button ops = sender as Button;
            //        //number in lble1 store it in a variable 
            //        f = Convert.ToDouble(label1.Text);
            //        //and put this num in label2
            //        label2.Text = label1.Text;
            //        //and make label1 be empty
            //        label1.Text = "";
            //        //this operator thhat I clicked store it in op var
            //        op = ops.Text;
            //        label2.Text = label2.Text + "" + op;
            //    }

            //}
            //if (ii == false)
            //{
            //    Button ops = sender as Button;
            //    //number in lble1 store it in a variable 
            //    f = Convert.ToDouble(label1.Text);
            //    //and put this num in label2
            //    label2.Text = label1.Text;
            //    //and make label1 be empty
            //    label1.Text = "";
            //    //this operator thhat I clicked store it in op var
            //    op = ops.Text;
            //    label2.Text = label2.Text + "" + op;
            //}
            Button ops = sender as Button;
            //number in lble1 store it in a variable 
            f = Convert.ToDouble(label1.Text);
            //and put this num in label2
            label2.Text = label1.Text;
            //and make label1 be empty
            label1.Text = "";
            //this operator thhat I clicked store it in op var
            op = ops.Text;
            label2.Text = label2.Text + "" + op;

        }
        //this fun convert num to binary num
        private void button15_Click(object sender, EventArgs e)
        {
            //
            if (Int64.TryParse(label1.Text,out n ))
            {
                label1.Text = (Convert.ToString(n, 2));
            }
            else
            {
                label1.Text = "";
            }
        }
        //this fun convert num to hexadecimal num
        private void button14_Click(object sender, EventArgs e)
        {
            if (Int64.TryParse(label1.Text, out n))
            {
                label1.Text = (Convert.ToString(n, 16));
            }
            else
            {
                label1.Text = "";
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            f = Convert.ToDouble( label1.Text);
            label1.Text = "";
            //here will take the value in label1 and will * in 3.14=>PI and division on 180
            //for make it in Degree like 30 degree
            f = f * Math.PI / 180;
            a = Math.Sin(f);
            label1.Text =Convert.ToString(a);
            label2.Text = "";


        }

        private void button20_Click(object sender, EventArgs e)
        {
            f = Convert.ToDouble(label1.Text);
            label1.Text = "";
            //here will take the value in label1 and will * in 3.14=>PI and division on 180
            //for make it in Degree like 30 degree
            f = f * Math.PI / 180;
            a = Math.Cos(f);
            label1.Text = Convert.ToString(a);
            label2.Text = "";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            f = Convert.ToDouble(label1.Text);
            label1.Text = "";
            //here will take the value in label1 and will * in 3.14=>PI and division on 180
            //for make it in Degree like 30 degree
            f = f * Math.PI / 180;
            a = Math.Tan(f);
            label1.Text = Convert.ToString(a);
            label2.Text = "";
        }

        private void button24_Click(object sender, EventArgs e)
        {
            a = Math.Log(Convert.ToDouble(label1.Text));
            label1.Text = Convert.ToString(a);
            label2.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button41_Click(object sender, EventArgs e)
        {

        }

        private void button40_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
