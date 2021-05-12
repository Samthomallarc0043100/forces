using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forces
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

        double sin(double x)
        {
            return (Math.Sin(x * Math.PI / 180.00));
        }
        double asin(double x)
        {
            return (Math.Asin(x) * 180.00 / Math.PI);
        }
        double cos(double x)
        {
            return (Math.Cos(x * Math.PI / 180.00));
        }
        double acos(double x)
        {
            return (Math.Acos(x) * 180.00 / Math.PI);
        }
        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
           


        }

        private void TabPage1_Click(object sender, EventArgs e)
        {

        }

        private void TabPage1_Click_1(object sender, EventArgs e)
        {

        }

        private void TabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                //read force and angle from textboxes
                double Force = double.Parse(textBox1.Text);
                double angle = double.Parse(textBox2.Text);
                //read Fx and Fy from labels 
                double Fx = Force * cos(angle);
                double Fy = Force * sin(angle);
                //run the code between these brackets 
                label1.Text = "Fx= " + Fx;
                label2.Text = "Fy= " + Fy;

                double Force = Math.Sqrt(Fx * Fy + Fy * Fy);

            }
            catch
            {
                //show error message
                MessageBox.Show("your a fool");
            }
        }

        private void TabPage2_Click(object sender, EventArgs e)
        {
            
             
        }
    }
    
    }




















