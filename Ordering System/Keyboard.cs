using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ordering_System
{
     partial class Keyboard : Form
    {
        Order order;
        public Keyboard(Order order)
        {
            InitializeComponent();
            this.order = order;
            BackColor = Color.FromArgb(100, 179, 222);
            button30.BackColor = Color.FromArgb(199, 55, 75);
            //textBox2.Focus();
        }

        private void Keyboard_Load(object sender, EventArgs e)
        {

        }

        

        private void button30_Click(object sender, EventArgs e)
        {
            order.setLab_Comment(textBox2.Text);

            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length < 46) textBox2.Text += "Q";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length < 46) textBox2.Text += "W";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length < 46) textBox2.Text += "E";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length < 46) textBox2.Text += "R";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length < 46) textBox2.Text += "T";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length < 46) textBox2.Text += "Y";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length < 46) textBox2.Text += "U";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length < 46) textBox2.Text += "I";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length < 46) textBox2.Text += "O";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length < 46) textBox2.Text += "P";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length < 46) textBox2.Text += "A";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length < 46) textBox2.Text += "S";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length < 46) textBox2.Text += "D";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length < 46) textBox2.Text += "F";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length < 46) textBox2.Text += "G";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length < 46) textBox2.Text += "H";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length < 46) textBox2.Text += "J";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length < 46) textBox2.Text += "K";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length < 46) textBox2.Text += "L";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length < 46) textBox2.Text += "Z";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length < 46) textBox2.Text += "X";
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length < 46) textBox2.Text += "C";
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length < 46) textBox2.Text += "V";
        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length < 46) textBox2.Text += "B";
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length < 46) textBox2.Text += "N";
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length < 46) textBox2.Text += "M";
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length < 46) textBox2.Text += ".";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length < 46) textBox2.Text += "!";
        }

        private void button31_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length < 46) textBox2.Text += " ";
               
        }

        private void button29_Click(object sender, EventArgs e)
        {
            string line = textBox2.Text;
            int delStartPosition = line.Length - 1;
            
            if (line.Length!=0)
                textBox2.Text = line.Remove(delStartPosition);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        
    }
}
