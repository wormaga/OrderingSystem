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
    public partial class SendPopUp : Form
    {
        Form2 myParent;
        public SendPopUp()
        {
            InitializeComponent();
        }
        public void setMyParent(Form2 myParent)
        {
            this.myParent = myParent;
        }


        private void button20_Click(object sender, EventArgs e)
        {
            //No button

            this.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Yes button
            myParent.send_yes = true;
            myParent.DoIneedToDoAnything();
            this.Close();
            //myParent.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
