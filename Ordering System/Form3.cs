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
    public partial class Form3 : Form
    {
        Form2 myParent;
        public Form3()
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
            myParent.cancel_yes = true;
            myParent.DoIneedToDoAnything();
            this.Close();
            //myParent.Close();
        }
    }
}
