using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpBasic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "boolean";
            textBox2.Text = sizeof(bool).ToString();
  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "char";
            textBox2.Text = sizeof(char).ToString();
            textBox3.Text = (char.MinValue - '\0' ).ToString();
            textBox4.Text = (char.MaxValue - '\0').ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "unsigned int 16 bit";
            textBox2.Text = sizeof(UInt16).ToString();
            textBox3.Text = UInt16.MinValue.ToString();
            textBox4.Text = UInt16.MaxValue.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Sbyte";
            textBox2.Text = sizeof(SByte).ToString();
            textBox3.Text = ("0").ToString();
            textBox4.Text = ("1").ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Long";
            textBox2.Text = sizeof(long).ToString();
            textBox3.Text = long.MinValue.ToString();
            textBox4.Text = long.MaxValue.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "float";
            textBox2.Text = sizeof(float).ToString();
            textBox3.Text = float.MinValue.ToString();
            textBox4.Text = float.MaxValue.ToString();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Byte";
            textBox2.Text = sizeof(Byte).ToString();
            textBox3.Text = Byte.MinValue.ToString();
            textBox4.Text = Byte.MaxValue.ToString();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = "ushort";
            textBox2.Text = sizeof(ushort).ToString();
            textBox3.Text = ushort.MinValue.ToString();
            textBox4.Text = ushort.MaxValue.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Short";
            textBox2.Text = sizeof(short).ToString();
            textBox3.Text = short.MinValue.ToString();
            textBox4.Text = short.MaxValue.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Int";
            textBox2.Text = sizeof(int).ToString();
            textBox3.Text = int.MinValue.ToString();
            textBox4.Text = int.MaxValue.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Ulong";
            textBox2.Text = sizeof(ulong).ToString();
            textBox3.Text = ulong.MinValue.ToString();
            textBox4.Text = ulong.MaxValue.ToString();
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "unsigned int 32 bit";
            textBox2.Text = sizeof(UInt32).ToString();
            textBox3.Text = UInt32.MinValue.ToString();
            textBox4.Text = UInt32.MaxValue.ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = "decimal";
            textBox2.Text = sizeof(decimal).ToString();
            textBox3.Text = decimal.MinValue.ToString();
            textBox4.Text = decimal.MaxValue.ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = "double";
            textBox2.Text = sizeof(double).ToString();
            textBox3.Text = double.MinValue.ToString();
            textBox4.Text = double.MaxValue.ToString();
        }
    }
   }

