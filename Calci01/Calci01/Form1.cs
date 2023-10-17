using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calci01
{
    public partial class Form1 : Form
    {
        string prevstr = "",ans="",Memory_recal="";
        bool deci = false;
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.Fixed3D; 
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }
        private void Button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = prevstr + "1";
            prevstr = textBox1.Text;
            text_box_scroll();
        }
        private void Button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = prevstr + "2";
            prevstr = textBox1.Text;
            text_box_scroll();
        }
        private void Button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = prevstr + "3";
            prevstr = textBox1.Text;
            text_box_scroll();
        }
        private void Button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = prevstr + "4";
            prevstr = textBox1.Text;
            text_box_scroll();
        }
        private void Button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = prevstr + "5";
            prevstr = textBox1.Text;
            text_box_scroll();
        }
        private void Button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = prevstr + "6";
            prevstr = textBox1.Text;
            text_box_scroll();
        }
        private void Button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = prevstr + "7";
            prevstr = textBox1.Text;
            text_box_scroll();
        }
        private void Button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = prevstr + "8";
            prevstr = textBox1.Text;
            text_box_scroll();
        }
        private void Button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = prevstr + "9";
            prevstr = textBox1.Text;
            text_box_scroll();
        }
        private void Button19_Click(object sender, EventArgs e)
        {
            textBox1.Text = prevstr + "0";
            prevstr = textBox1.Text;
            text_box_scroll();
        }
        private void Button17_Click(object sender, EventArgs e)
        {
            if(prevstr=="")
            {
                textBox1.Text = "0.";
                prevstr = textBox1.Text;
                text_box_scroll();
                return;
            }
            deci = Check_Decimal_number(prevstr);
            if (deci == false)
            {
                textBox1.Text =prevstr + ".";
                prevstr = textBox1.Text;
                text_box_scroll();
            }
            else
            {
                MessageBox.Show("Can only have one decimal per interger.\nPlease check you'r equation again.","Format Error",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
        }
        private void Button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = prevstr + " + ";
            prevstr = textBox1.Text;
            text_box_scroll();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            prevstr = prevstr.Remove(prevstr.Length - 1,1);
            textBox1.Text = prevstr;
            text_box_scroll();
        }
        private void Button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = prevstr + " - ";
            prevstr = textBox1.Text;
            text_box_scroll();
        }
        private void Button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = prevstr + " x ";
            prevstr = textBox1.Text;
            text_box_scroll();
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = prevstr + " / ";
            prevstr = textBox1.Text;
            text_box_scroll();
        }
        private void Button24_Click(object sender, EventArgs e)
        {
            textBox1.Text = prevstr + " ( ";
            prevstr = textBox1.Text;
            text_box_scroll();
        }
        private void Button23_Click(object sender, EventArgs e)
        {
            textBox1.Text = prevstr + " ) ";
            prevstr = textBox1.Text;
            text_box_scroll();
        }

        private void Button18_Click(object sender, EventArgs e)
        {
            Memory_recal = prevstr;
            var expression = prevstr.Replace('x','*');
            var result = new DataTable().Compute(expression,"") + "";
            ans = result.ToString();
            textBox1.Text = ans;
            prevstr = string.Empty;
        }
        private void Button4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void Button21_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello Friends,This is my very first complete project(which gives me ick 🤢)\nStill,I am very happy to finally complete this fuckin kinda shitty cacli.\nConsider this as the end of the Easter Egg.\n#AI_WILL_TAKE_MY_JOB 🤭","Easter Egg Timee",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        private void Button22_Click(object sender, EventArgs e)
        {
            prevstr = "";
            ans = "";
            deci = false;
            Memory_recal = "";
            textBox1.Text = "";
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = Memory_recal;
        }
        //User Defined Functions.
        private void text_box_scroll()
        {
            textBox1.SelectionStart = textBox1.TextLength;
            textBox1.ScrollToCaret();
        }
        private bool Check_Decimal_number(string str)
        {
            int str_len = str.Length, last_oper_index = -1;
            for (int i = 0; i < str_len; i++)
            {
                if (str[i] == '+' || str[i] == '-' || str[i] == 'x' || str[i] == '/' || str[i] == '(' || i == 0)
                {
                    last_oper_index = i;
                }
            }
            if (last_oper_index != -1)
            {
                for (int i = last_oper_index + 1; i < str_len; i++)
                {
                    if (str[i] == '.')
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}