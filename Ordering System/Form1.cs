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
    public partial class F_HomeSrceen : Form
    {
        Dictionary<string, Form2> seats;
        Form2 myChild;
        Form2 seatNo_B4 = new Form2();
        public F_HomeSrceen()
        {
            InitializeComponent();
            seats = new Dictionary<string, Form2 > ();
           

        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            //help Button
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form2 seatNo_B4;
            if (!seats.ContainsKey("b4"))
            {
                
                seatNo_B4 = new Form2();
                myChild = seatNo_B4;
                myChild.setMyParent(this);
                seatNo_B4.textBox1.Text = "Seat number: " + button11.Text;
                seats.Add("b4", seatNo_B4);
                seats["b4"].Show();
                this.Hide();
            }
            else
            {
                seats["b4"].Show();
                this.Hide();
            }

        }

        private void F_HomeSrceen_Load(object sender, EventArgs e)
        {
           
            BackColor = Color.FromArgb(100, 179,222);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 seatNo_C10;
            if (!seats.ContainsKey("c10"))
            {
                seatNo_C10 = new Form2();
                myChild = seatNo_C10;
                myChild.setMyParent(this);
                seatNo_C10.textBox1.Text = "Seat number: " + button6.Text;
                seats.Add("c10", seatNo_C10);
                seats["c10"].Show();
                this.Hide();
            }
            else
            {
                seats["c10"].Show();
                this.Hide();
                
            }
        }
    

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 seatNo_A6;
            if (!seats.ContainsKey("a6"))
            {
                seatNo_A6 = new Form2();
                myChild = seatNo_A6;
                myChild.setMyParent(this);
                seatNo_A6.textBox1.Text = "Seat number: " + button2.Text;
                seats.Add("a6", seatNo_A6);
                seats["a6"].Show();
                this.Hide();
            }
            else
            {
                seats["a6"].Show();
                this.Hide();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form2 seatNo_F3;
            if (!seats.ContainsKey("f3"))
            {
                seatNo_F3 = new Form2();
                myChild = seatNo_F3;
                myChild.setMyParent(this);
                seatNo_F3.textBox1.Text = "Seat number: " + button10.Text;
                seats.Add("f3", seatNo_F3);
                seats["f3"].Show();
                this.Hide();
            }
            else
            {
                seats["f3"].Show();
                this.Hide();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form2 seatNo_E2;
            if (!seats.ContainsKey("e2"))
            {
                seatNo_E2 = new Form2();
                myChild = seatNo_E2;
                myChild.setMyParent(this);
                seatNo_E2.textBox1.Text = "Seat number: " + button9.Text;
                seats.Add("e2", seatNo_E2);
                seats["e2"].Show();
                this.Hide();
            }
            else
            {

                seats["e2"].Show();
                this.Hide();

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 seatNo_D18;
            if (!seats.ContainsKey("d18"))
            {
                seatNo_D18 = new Form2();
                myChild = seatNo_D18;
                myChild.setMyParent(this);
                seatNo_D18.textBox1.Text = "Seat number: " + button5.Text;
                seats.Add("d18", seatNo_D18);
                seats["d18"].Show();
                this.Hide();

            }
            else
            {
                seats["d18"].Show();
                this.Hide();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form2 seatNo_D9;
            if (!seats.ContainsKey("d9"))
            {
                seatNo_D9 = new Form2();
                myChild = seatNo_D9;
                myChild.setMyParent(this);
                seatNo_D9.textBox1.Text = "Seat number: " + button7.Text;
                seats.Add("d9", seatNo_D9);
                seats["d9"].Show();
                this.Hide();            }
            else
            {
                seats["d9"].Show();
                this.Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 seatNo_C11;
            if (!seats.ContainsKey("c11"))
            {
                seatNo_C11 = new Form2();
                myChild = seatNo_C11;
                myChild.setMyParent(this);
                seatNo_C11.textBox1.Text = "Seat number: " + button4.Text;
                seats.Add("c11", seatNo_C11);
                seats["c11"].Show();
                this.Hide();
            }
            else
            {
                seats["c11"].Show();
                this.Hide();

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form2 seatNo_T4;
            if (!seats.ContainsKey("t4"))
            {
                seatNo_T4 = new Form2();
                myChild = seatNo_T4;
                myChild.setMyParent(this);
                seatNo_T4.textBox1.Text = "Seat number: " + button8.Text;
                seats.Add("t4", seatNo_T4);
                seats["t4"].Show();
                this.Hide();
            }
            else
            {
                seats["t4"].Show();
                this.Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 seatNo_Z6;
            if (!seats.ContainsKey("z6"))
            {
                seatNo_Z6 = new Form2();
                myChild = seatNo_Z6;
                myChild.setMyParent(this);
                seatNo_Z6.textBox1.Text = "Seat number: " + button3.Text;
                seats.Add("z6", seatNo_Z6);
                seats["z6"].Show();
                this.Hide();
            }
            else
            {
                seats["z6"].Show();
                this.Hide();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form2 seatNo_H4;
            if (!seats.ContainsKey("h4"))
            {
                seatNo_H4 = new Form2();
                myChild = seatNo_H4;
                myChild.setMyParent(this);
                seatNo_H4.textBox1.Text = "Seat number: " + button12.Text;
                seats.Add("h4", seatNo_H4);
                seats["h4"].Show();
                this.Hide();
            }
            else
            {
                seats["h4"].Show();
                this.Hide();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Form2 seatNo_U5;
            if (!seats.ContainsKey("u5"))
            {
                seatNo_U5 = new Form2();
                myChild = seatNo_U5;
                myChild.setMyParent(this);
                seatNo_U5.textBox1.Text = "Seat number: " + button13.Text;
                seats.Add("u5", seatNo_U5);
                seats["u5"].Show();
                this.Hide();
            }
            else
            {
                seats["u5"].Show();
                this.Hide();
            }
        }
    }
}
