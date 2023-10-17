using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {

            DateTime date1 = DateTime.Now;
            DateTime date2 = DateTime.Now;
            if (radioButton1.Checked==true)
            {
                label1.Text = date1.ToString("hh:mm:ss.ff tt");
                label3.Text = date2.ToString("dd/MM/yyyy");
            }
            else if(radioButton2.Checked==true)
            {
                TimeSpan dura = new TimeSpan(00,04, 30, 00);
                label1.Text = date1.Subtract(dura).ToString("hh:mm:ss.ff tt");
                label3.Text = date2.Subtract(dura).ToString("dd/MM/yyyy");
            }
            else if(radioButton4.Checked==true)
            {
                TimeSpan dura = new TimeSpan(00,02, 30, 00);
                label1.Text = date1.Subtract(dura).ToString("hh:mm:ss.ff tt");
                label3.Text = date2.Subtract(dura).ToString("dd/MM/yyyy");
            }
            else
            {
                TimeSpan dura = new TimeSpan(00,09, 30, 00);
                label1.Text = date1.Subtract(dura).ToString("hh:mm:ss.ff tt");
                label3.Text = date2.Subtract(dura).ToString("dd/MM/yyyy");
            }
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }
    }
}
