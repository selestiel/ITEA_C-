using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgeProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Ynow = DateTime.Now.Year;
            int Mnow = DateTime.Now.Month;
            int Dnow = DateTime.Now.Day;
            int Hnow = DateTime.Now.Hour;
            int YC = Convert.ToInt32(textBox1.Text);
            int YAge = Ynow - YC;
            int MC = Convert.ToInt32(textBox3.Text);
            int MAge = Mnow - MC;
            int DC = Convert.ToInt32(textBox4.Text);
            int DAge = Dnow - DC;
            int HC = Convert.ToInt32(textBox5.Text);
            int HAge = Hnow - HC;
            textBox2.Text = (Convert.ToString(YAge) + " years " + Convert.ToString(MAge) + " months " + Convert.ToString(DAge) + " days " + Convert.ToString(HAge) + " hours ");
        }
    }
}
