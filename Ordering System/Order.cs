using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using Ordering_System.Properties;

namespace Ordering_System
{
    class Order
    {
        private Form2 myParent;
        private int count;
        private Item item;
        private FlowLayoutPanel picPanel;
        private Panel panel;
        private PictureBox minus, del, comment;
        private Image im_minus, im_del, im_comment;
        private Label lab_count, lab_name, lab_comment;

        

        public Order(Item item, Form2 myParent)
        {
            this.item = item;
            this.myParent = myParent;
            count = 1;


            //
            //Comment button
            //
            comment = new PictureBox();
            im_comment = Resources.comment__0_00_01_21_;
            comment.Image = im_comment;
            comment.Size = new System.Drawing.Size(30, 30);
            comment.SizeMode = PictureBoxSizeMode.StretchImage;
            //comment.BorderStyle = BorderStyle.FixedSingle;
            
            
            //
            //minus button
            //
            minus = new PictureBox();
            im_minus = Resources.Subtract_icon__0_00_00_00_;
            minus.Image = im_minus;
            minus.Size = new System.Drawing.Size(30, 30);
            minus.SizeMode = PictureBoxSizeMode.StretchImage;
           // minus.BorderStyle = BorderStyle.FixedSingle;
            minus.Margin = new Padding(30, 3, 3, 3);


            //
            //Del button
            //
            del = new PictureBox();
            im_del = Resources.No_icon__0_00_00_00_;
            del.Image = im_del;
            del.Size = new System.Drawing.Size(30, 30);
            del.SizeMode = PictureBoxSizeMode.StretchImage;
            //del.BorderStyle = BorderStyle.FixedSingle;
            del.Margin = new Padding(30, 3, 3, 3);

            //
            //Picture panel
            //
            picPanel = new FlowLayoutPanel();
            //picPanel.BorderStyle = BorderStyle.FixedSingle;
            picPanel.Controls.Add(comment);
            picPanel.Controls.Add(minus);
            picPanel.Controls.Add(del);
            picPanel.Location = new Point(220, 5);
            picPanel.AutoSize = true;
            picPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;

            //
            //Label count
            //
            lab_count = new Label(); lab_count.Text = "" + count + "x"; lab_count.Text = "" + count + "x";
            lab_count.Font = new Font("Times New Roman", 14.25f);
            lab_count.Location = new Point(7, 10);
            //lab_count.BorderStyle = BorderStyle.FixedSingle;
            lab_count.AutoSize = true;
            

            //
            //Lablel name
            //
            lab_name = new Label(); lab_name.Text = item.getItemName();
            lab_name.Font = new Font("Times New Roman", 14.25f);               
            lab_name.Location = new Point(55, 10);
            //lab_name.BorderStyle = BorderStyle.FixedSingle;
            lab_name.AutoSize = true;

            //
            //Label comment
            //
            lab_comment = new Label();
            lab_comment.Text = "";
            lab_comment.Font = new Font("Times New Roman", 10.0f);
            lab_comment.ForeColor = Color.Red;
            lab_comment.Location = new Point(55, 35);
            //lab_count.BorderStyle = BorderStyle.FixedSingle;
            lab_comment.AutoSize = true;
            lab_comment.MaximumSize = new Size(165, 35);
            


            //
            //Panel to display (a line)
            //
            panel = new Panel();
            panel.BorderStyle = BorderStyle.Fixed3D;
            panel.Size = new Size(390, 40);
            panel.Padding = new Padding(5, 5, 5, 5);
            panel.AutoSize = true;
            panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            panel.Controls.Add(lab_count);
            panel.Controls.Add(lab_name);
            panel.Controls.Add(picPanel);

            //
            //Events for picture boxes
            //
            comment.Click += new System.EventHandler(comment_action);
            minus.Click += new System.EventHandler(minus_action);
            del.Click += new System.EventHandler(del_action);

        }

        public void comment_action(object sender, EventArgs e)
        {
            //TODO 
            //text get from keboard
            if (lab_comment.Text.Length != 0) panel.Controls.Add(lab_comment);
            Keyboard key = new Keyboard(this);
            key.textBox1.Text = myParent.textBox1.Text;
            key.textBox2.Text = lab_comment.Text;
            key.Show();

            
        }

        

        public void minus_action(object sender, EventArgs e)
        {
            decrementCount();
            myParent.updateDisplayForPanelLine();
        }

        public void del_action(object sender, EventArgs e)
        {
            count = 0;
            myParent.updateDisplayForPanelLine();
        }

        public Panel getPanel()
        {
            return panel;
        }

        public void incrementCount()
        {
            count += 1;
            lab_count.Text = "" + count + "x";
            /*
            if (count < 10) lab_name.Location = new Point(40, 10);
            else lab_name.Location = new Point(55, 10);
            */
        }

        public void decrementCount()
        {
            if (count > 0) count -= 1;
            lab_count.Text = "" + count + "x";
            /*
            if (count < 10) lab_name.Location = new Point(40, 10);
            else lab_name.Location = new Point(55, 10);
           */


        }

        public Item getItem()
        {
            return item;
        }

        public int getCount()
        {
            return count;
        }

        public Label getlab_count()
        {
            return lab_count;
        }

        public Label getLab_comment()
        {
            return lab_comment;
        }

        public Form2 getMyParent()
        {
            return myParent;
        }

        public void setCount(int value)
        {
            count = value;
        }

        public void setLab_Comment(string someText)
        {
            lab_comment.Text = someText;
            if (lab_comment.Text.Length != 0) panel.Controls.Add(lab_comment);
            else panel.Controls.Remove(lab_comment);
        }

        public void setlab_count(string value)
        {
            lab_count.Text = value;
        }
    }
}
