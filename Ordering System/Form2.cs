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
    public partial class Form2 : Form
    {
         Dictionary<int, Item> food, temp_food;
         Dictionary<int, Order> order_to_display, temp_orderToDisplay;
         public bool cancel_yes, send_yes;
        

        private F_HomeSrceen myParent;
        private Form3 myChild;
        private SendPopUp myChild2;
        public Form2()
        {
            InitializeComponent();
            order_to_display = new Dictionary<int, Order>();
            temp_orderToDisplay = new Dictionary<int, Order>();
            cancel_yes = false;
            send_yes = false;

            food = new Dictionary<int, Item>();
            temp_food = new Dictionary<int, Item>();
            setUpFood();
            setUpFoodTemp();

            

        }

       
        private void setUpFood()
        {
            
            //Starters
            Item foodItem1 = new Item("Crab Cake", 1); food.Add(1, foodItem1);
            Item foodItem2 = new Item("Whitebait", 2); food.Add(2, foodItem2);
            Item foodItem3 = new Item("Feta Salad", 3); food.Add(3, foodItem3);
            Item foodItem4 = new Item("Avocado", 4); food.Add(4, foodItem4);
            Item foodItem5 = new Item("Chilled pea", 5); food.Add(5, foodItem5);
            Item foodItem6 = new Item("Tuna Suhi", 6); food.Add(6, foodItem6);
            Item foodItem7 = new Item("Chicken Wings", 7); food.Add(7, foodItem7);
            Item foodItem8 = new Item("Potted Crab", 8); food.Add(8, foodItem8);
            Item foodItem9 = new Item("Statrets", 9); food.Add(9, foodItem9);
            Item foodItem10 = new Item("Prawns", 10); food.Add(10, foodItem10);
            Item foodItem11 = new Item("Spring Tart", 11); food.Add(11, foodItem11);
            Item foodItem12 = new Item("Borscht", 12); food.Add(12, foodItem12);
            Item foodItem13 = new Item("Smoked salmon", 13); food.Add(13, foodItem13);


            //Mains
            Item foodItem14 = new Item("Rizotto", 14); food.Add(14, foodItem14);
            Item foodItem15 = new Item("Roast Chicken", 15); food.Add(15, foodItem15);
            Item foodItem16 = new Item("Cod", 16); food.Add(16, foodItem16);
            Item foodItem17 = new Item("Seabass", 17); food.Add(17, foodItem17);
            Item foodItem18 = new Item("Sirlion Steak", 18); food.Add(18, foodItem18);
            Item foodItem19 = new Item("Ravioli", 19); food.Add(19, foodItem19);
            Item foodItem20 = new Item("Burger", 20); food.Add(20, foodItem20);
            Item foodItem21 = new Item("Rice Salad", 21); food.Add(21, foodItem21);
            Item foodItem22 = new Item("Spaghetti", 22); food.Add(22, foodItem22);
            Item foodItem23 = new Item("Lamb", 23); food.Add(23, foodItem23);

            //Deserts
            Item foodItem24 = new Item("Lemon Pie", 24); food.Add(24, foodItem24);
            Item foodItem25 = new Item("Lemon Sorbet", 25); food.Add(25, foodItem25);
            Item foodItem26 = new Item("Ice cream", 26); food.Add(26, foodItem26);
            Item foodItem27 = new Item("Cherry flans", 27); food.Add(27, foodItem27);
            Item foodItem28 = new Item("Rainbow jelly", 28); food.Add(28, foodItem28);
            Item foodItem29 = new Item("Pear pudding", 29); food.Add(29, foodItem29);
            Item foodItem30 = new Item("Brownie", 30); food.Add(30, foodItem30);

            //Drinks
            Item foodItem31 = new Item("Green tea", 31); food.Add(31, foodItem31);
            Item foodItem32 = new Item("Late", 32); food.Add(32, foodItem32);
            Item foodItem33 = new Item("Coke", 33); food.Add(33, foodItem33);
            Item foodItem34 = new Item("Still water", 34); food.Add(34, foodItem34);
            Item foodItem35 = new Item("Rum", 35); food.Add(35, foodItem35);
            Item foodItem36 = new Item("Red wine", 36); food.Add(36, foodItem36);
            Item foodItem37 = new Item("White wine", 37); food.Add(37, foodItem37);
            Item foodItem38 = new Item("Black tea", 38); food.Add(38, foodItem38);
            Item foodItem39 = new Item("Apple juice", 39); food.Add(39, foodItem39);

            /*
            Item foodItem40 = new Item("", 40); food.Add(40, foodItem40);
            Item foodItem41 = new Item("", 41); food.Add(41, foodItem41);
            Item foodItem42 = new Item("", 42); food.Add(42, foodItem42);
            Item foodItem43 = new Item("", 43); food.Add(43, foodItem43);
            Item foodItem44 = new Item("", 44); food.Add(44, foodItem44);
            Item foodItem45 = new Item("", 45); food.Add(45, foodItem45);
            Item foodItem46 = new Item("", 46); food.Add(46, foodItem46);
            Item foodItem47 = new Item("", 47); food.Add(47, foodItem47);
            Item foodItem48 = new Item("", 48); food.Add(48, foodItem48);
            Item foodItem49 = new Item("", 49); food.Add(49, foodItem49);
            Item foodItem50 = new Item("", 50); food.Add(50, foodItem50);
            Item foodItem51 = new Item("", 51); food.Add(51, foodItem51);
            Item foodItem52 = new Item("", 52); food.Add(52, foodItem52);
            Item foodItem53 = new Item("", 53); food.Add(53, foodItem53);
            Item foodItem54 = new Item("", 54); food.Add(54, foodItem54);
            Item foodItem55 = new Item("", 55); food.Add(55, foodItem55);
            Item foodItem56 = new Item("", 56); food.Add(56, foodItem56);
            Item foodItem57 = new Item("", 57); food.Add(57, foodItem57);
            Item foodItem58 = new Item("", 58); food.Add(58, foodItem58);
            Item foodItem59 = new Item("", 59); food.Add(59, foodItem59);
            Item foodItem60 = new Item("", 60); food.Add(60, foodItem60);
            Item foodItem61 = new Item("", 61); food.Add(61, foodItem61);
            Item foodItem62 = new Item("", 62); food.Add(62, foodItem62);
            Item foodItem63 = new Item("", 63); food.Add(63, foodItem63);
            Item foodItem64 = new Item("", 64); food.Add(64, foodItem64);
            Item foodItem65 = new Item("", 65); food.Add(65, foodItem65);
            Item foodItem66 = new Item("", 66); food.Add(66, foodItem66);
            Item foodItem67 = new Item("", 67); food.Add(67, foodItem67);
            Item foodItem68 = new Item("", 68); food.Add(68, foodItem68);
            Item foodItem69 = new Item("", 69); food.Add(69, foodItem69);
            Item foodItem70 = new Item("", 70); food.Add(70, foodItem70);
            Item foodItem71 = new Item("", 71); food.Add(71, foodItem71);
            Item foodItem72 = new Item("", 72); food.Add(72, foodItem72);
            Item foodItem73 = new Item("", 73); food.Add(73, foodItem73);
            Item foodItem74 = new Item("", 74); food.Add(74, foodItem74);
            Item foodItem75 = new Item("", 75); food.Add(75, foodItem75);
            Item foodItem76 = new Item("", 76); food.Add(76, foodItem76);
            Item foodItem77 = new Item("", 77); food.Add(77, foodItem77);
            Item foodItem78 = new Item("", 78); food.Add(78, foodItem78);
            Item foodItem79 = new Item("", 79); food.Add(79, foodItem79);
            Item foodItem80 = new Item("", 80); food.Add(80, foodItem80);
            */
        }

        private void setUpFoodTemp()
        {

            //Starters
            Item foodItem1 = new Item("Crab Cake", 1); temp_food.Add(1, foodItem1);
            Item foodItem2 = new Item("Whitebait", 2); temp_food.Add(2, foodItem2);
            Item foodItem3 = new Item("Feta Salad", 3); temp_food.Add(3, foodItem3);
            Item foodItem4 = new Item("Avocado", 4); temp_food.Add(4, foodItem4);
            Item foodItem5 = new Item("Chilled pea", 5); temp_food.Add(5, foodItem5);
            Item foodItem6 = new Item("Tuna Suhi", 6); temp_food.Add(6, foodItem6);
            Item foodItem7 = new Item("Chicken Wings", 7); temp_food.Add(7, foodItem7);
            Item foodItem8 = new Item("Potted Crab", 8); temp_food.Add(8, foodItem8);
            Item foodItem9 = new Item("Statrets", 9); temp_food.Add(9, foodItem9);
            Item foodItem10 = new Item("Prawns", 10); temp_food.Add(10, foodItem10);
            Item foodItem11 = new Item("Spring Tart", 11); temp_food.Add(11, foodItem11);
            Item foodItem12 = new Item("Borscht", 12); temp_food.Add(12, foodItem12);
            Item foodItem13 = new Item("Smoked salmon", 13); temp_food.Add(13, foodItem13);


            //Mains
            Item foodItem14 = new Item("Rizotto", 14); temp_food.Add(14, foodItem14);
            Item foodItem15 = new Item("Roast Chicken", 15); temp_food.Add(15, foodItem15);
            Item foodItem16 = new Item("Cod", 16); temp_food.Add(16, foodItem16);
            Item foodItem17 = new Item("Seabass", 17); temp_food.Add(17, foodItem17);
            Item foodItem18 = new Item("Sirlion Steak", 18); temp_food.Add(18, foodItem18);
            Item foodItem19 = new Item("Ravioli", 19); temp_food.Add(19, foodItem19);
            Item foodItem20 = new Item("Burger", 20); temp_food.Add(20, foodItem20);
            Item foodItem21 = new Item("Rice Salad", 21); temp_food.Add(21, foodItem21);
            Item foodItem22 = new Item("Spaghetti", 22); temp_food.Add(22, foodItem22);
            Item foodItem23 = new Item("Lamb", 23); temp_food.Add(23, foodItem23);

            //Deserts
            Item foodItem24 = new Item("Lemon Pie", 24); temp_food.Add(24, foodItem24);
            Item foodItem25 = new Item("Lemon Sorbet", 25); temp_food.Add(25, foodItem25);
            Item foodItem26 = new Item("Ice cream", 26); temp_food.Add(26, foodItem26);
            Item foodItem27 = new Item("Cherry flans", 27); temp_food.Add(27, foodItem27);
            Item foodItem28 = new Item("Rainbow jelly", 28); temp_food.Add(28, foodItem28);
            Item foodItem29 = new Item("Pear pudding", 29); temp_food.Add(29, foodItem29);
            Item foodItem30 = new Item("Brownie", 30); temp_food.Add(30, foodItem30);

            //Drinks
            Item foodItem31 = new Item("Green tea", 31); temp_food.Add(31, foodItem31);
            Item foodItem32 = new Item("Late", 32); temp_food.Add(32, foodItem32);
            Item foodItem33 = new Item("Coke", 33); temp_food.Add(33, foodItem33);
            Item foodItem34 = new Item("Still water", 34); temp_food.Add(34, foodItem34);
            Item foodItem35 = new Item("Rum", 35); temp_food.Add(35, foodItem35);
            Item foodItem36 = new Item("Red wine", 36); temp_food.Add(36, foodItem36);
            Item foodItem37 = new Item("White wine", 37); temp_food.Add(37, foodItem37);
            Item foodItem38 = new Item("Black tea", 38); temp_food.Add(38, foodItem38);
            Item foodItem39 = new Item("Apple juice", 39); temp_food.Add(39, foodItem39);

            /*
            Item foodItem40 = new Item("", 40); temp_food.Add(40, foodItem40);
            Item foodItem41 = new Item("", 41); temp_food.Add(41, foodItem41);
            Item foodItem42 = new Item("", 42); temp_food.Add(42, foodItem42);
            Item foodItem43 = new Item("", 43); temp_food.Add(43, foodItem43);
            Item foodItem44 = new Item("", 44); temp_food.Add(44, foodItem44);
            Item foodItem45 = new Item("", 45); temp_food.Add(45, foodItem45);
            Item foodItem46 = new Item("", 46); temp_food.Add(46, foodItem46);
            Item foodItem47 = new Item("", 47); temp_food.Add(47, foodItem47);
            Item foodItem48 = new Item("", 48); temp_food.Add(48, foodItem48);
            Item foodItem49 = new Item("", 49); temp_food.Add(49, foodItem49);
            Item foodItem50 = new Item("", 50); temp_food.Add(50, foodItem50);
            Item foodItem51 = new Item("", 51); temp_food.Add(51, foodItem51);
            Item foodItem52 = new Item("", 52); temp_food.Add(52, foodItem52);
            Item foodItem53 = new Item("", 53); temp_food.Add(53, foodItem53);
            Item foodItem54 = new Item("", 54); temp_food.Add(54, foodItem54);
            Item foodItem55 = new Item("", 55); temp_food.Add(55, foodItem55);
            Item foodItem56 = new Item("", 56); temp_food.Add(56, foodItem56);
            Item foodItem57 = new Item("", 57); temp_food.Add(57, foodItem57);
            Item foodItem58 = new Item("", 58); temp_food.Add(58, foodItem58);
            Item foodItem59 = new Item("", 59); temp_food.Add(59, foodItem59);
            Item foodItem60 = new Item("", 60); temp_food.Add(60, foodItem60);
            Item foodItem61 = new Item("", 61); temp_food.Add(61, foodItem61);
            Item foodItem62 = new Item("", 62); temp_food.Add(62, foodItem62);
            Item foodItem63 = new Item("", 63); temp_food.Add(63, foodItem63);
            Item foodItem64 = new Item("", 64); temp_food.Add(64, foodItem64);
            Item foodItem65 = new Item("", 65); temp_food.Add(65, foodItem65);
            Item foodItem66 = new Item("", 66); temp_food.Add(66, foodItem66);
            Item foodItem67 = new Item("", 67); temp_food.Add(67, foodItem67);
            Item foodItem68 = new Item("", 68); temp_food.Add(68, foodItem68);
            Item foodItem69 = new Item("", 69); temp_food.Add(69, foodItem69);
            Item foodItem70 = new Item("", 70); temp_food.Add(70, foodItem70);
            Item foodItem71 = new Item("", 71); temp_food.Add(71, foodItem71);
            Item foodItem72 = new Item("", 72); temp_food.Add(72, foodItem72);
            Item foodItem73 = new Item("", 73); temp_food.Add(73, foodItem73);
            Item foodItem74 = new Item("", 74); temp_food.Add(74, foodItem74);
            Item foodItem75 = new Item("", 75); temp_food.Add(75, foodItem75);
            Item foodItem76 = new Item("", 76); temp_food.Add(76, foodItem76);
            Item foodItem77 = new Item("", 77); temp_food.Add(77, foodItem77);
            Item foodItem78 = new Item("", 78); temp_food.Add(78, foodItem78);
            Item foodItem79 = new Item("", 79); temp_food.Add(79, foodItem79);
            Item foodItem80 = new Item("", 80); temp_food.Add(80, foodItem80);
            */
        }


        public void updateDisplayForPanelLine()
        {
            //display_panel.Controls.Clear();
            foreach (var obj in temp_orderToDisplay)
            {
                Order order = obj.Value;
                if (order.getCount() == 0)
                {
                    display_panel.Controls.Remove(order.getPanel());
                   // order_to_display.Remove(obj.Key);
                }
                //display_panel.Controls.Add(order.getPanel());
            }



        }
        public void updateDisplay()
        {    
            display_panel.Controls.Clear();
            foreach(var obj in temp_orderToDisplay)
            {
                Order order = obj.Value;
                if (order.getCount() == 0)
                {
                    display_panel.Controls.Remove(order.getPanel());
                    //order_to_display.Remove(obj.Key); //?????????
                }
                display_panel.Controls.Add(order.getPanel());
            }
            
    
           
        }

        public void setMyParent(F_HomeSrceen myParent)
        {
            this.myParent = myParent;
        }

        private void TempOrderEqualsOrder()
        {
            temp_orderToDisplay.Clear();
            foreach (var obj in order_to_display)
            {
                if (obj.Value.getCount() != 0)
                {
                    Order newOrder = new Order(obj.Value.getItem(), obj.Value.getMyParent());
                    int a = obj.Value.getCount();
                    newOrder.setCount(a);
                    string aa = obj.Value.getlab_count().Text;
                    newOrder.setlab_count(aa);
                    string aaa = obj.Value.getLab_comment().Text;
                    newOrder.setLab_Comment(aaa);

                    temp_orderToDisplay.Add(obj.Key, newOrder);
                }
                
            }
        }

        private void OrderEqualsTempOrder()
        {
            order_to_display.Clear();
            foreach (var obj in temp_orderToDisplay)
            {
                if (obj.Value.getCount() != 0)
                {
                    Order newOrder = new Order(obj.Value.getItem(), obj.Value.getMyParent());
                    int a = obj.Value.getCount();
                    newOrder.setCount(a);
                    string aa = obj.Value.getlab_count().Text;
                    newOrder.setlab_count(aa);
                    string aaa = obj.Value.getLab_comment().Text;
                    newOrder.setLab_Comment(aaa);

                    order_to_display.Add(obj.Key, newOrder);
                }
            }
        }
        public void DoIneedToDoAnything()
        {
            if (cancel_yes)
            {

                TempOrderEqualsOrder();//temp_orderToDisplay = order_to_display;
                updateDisplay();
                cancel_yes = false;
            }

            if (send_yes)
            {
                OrderEqualsTempOrder(); //order_to_display = temp_orderToDisplay;
                //updateDisplay();
                send_yes = false;
            }
        }
        
        private void printMyButtons()
        {
           // FlowLayoutPanel panel1
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(100, 179, 222);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //TODO
            SendPopUp jj = new SendPopUp();
            myChild2 = jj;
            myChild2.setMyParent(this);
            myChild2.Show();

            // OrderEqualsTempOrder();   // order_to_display = temp_orderToDisplay;
            //updateDisplay(); //this is checking storing to order_to_display

        }

        private void button3_BindingContextChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_BackColorChanged(object sender, EventArgs e)
        {
            
        }

        private void button20_BackColorChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {
                Form3 j = new Form3();
                myChild = j;
                myChild.setMyParent(this);
            
                myChild.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            //TODO
            //make search
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            panel_Starters.Visible = true;
            panel_Mains.Visible = false;
            panel_deserts.Visible = false;
            panel_drinks.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel_Starters.Visible = false;
            panel_Mains.Visible = true;
            panel_deserts.Visible = false;
            panel_drinks.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel_Starters.Visible = false;
            panel_Mains.Visible = false;
            panel_deserts.Visible = true;
            panel_drinks.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel_Starters.Visible = false;
            panel_Mains.Visible = false;
            panel_deserts.Visible = false;
            panel_drinks.Visible = true;
        }

       
           
        
        private void actionForFoodButton(int itemID)
        {
            if (temp_orderToDisplay.ContainsKey(itemID) && temp_orderToDisplay[itemID].getCount() > 0)
            {
                temp_orderToDisplay[itemID].incrementCount();
            }

            if (!temp_orderToDisplay.ContainsKey(itemID))
            {
                Order newOrder = new Order(food[itemID], this);
                temp_orderToDisplay.Add(itemID, newOrder);
                display_panel.Controls.Add(temp_orderToDisplay[itemID].getPanel());
            }

            if (temp_orderToDisplay.ContainsKey(itemID) && temp_orderToDisplay[itemID].getCount() == 0)
            {
                display_panel.Controls.Add(temp_orderToDisplay[itemID].getPanel());
                temp_orderToDisplay[itemID].incrementCount();
            }
        }
        private void button12_Click(object sender, EventArgs e)
        {
            actionForFoodButton(1);
        }
        
        private void button11_Click(object sender, EventArgs e)
        {
            actionForFoodButton(2);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            actionForFoodButton(3);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            actionForFoodButton(4);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            actionForFoodButton(5);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            actionForFoodButton(6);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            actionForFoodButton(7);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            actionForFoodButton(8);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            actionForFoodButton(9);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            actionForFoodButton(10);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            actionForFoodButton(11);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            actionForFoodButton(12);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            actionForFoodButton(13);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            actionForFoodButton(14);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            actionForFoodButton(15);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            actionForFoodButton(16);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            actionForFoodButton(17);
        }

        private void button33_Click(object sender, EventArgs e)
        {
            actionForFoodButton(18);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            actionForFoodButton(19);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            actionForFoodButton(20);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            actionForFoodButton(21);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            actionForFoodButton(22);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            actionForFoodButton(23);
        }

        private void button36_Click(object sender, EventArgs e)
        {
            actionForFoodButton(24);
        }

        private void button37_Click(object sender, EventArgs e)
        {
            actionForFoodButton(25);
        }

        private void button38_Click(object sender, EventArgs e)
        {
            actionForFoodButton(26);
        }

        private void button39_Click(object sender, EventArgs e)
        {
            actionForFoodButton(27);
        }

        private void button40_Click(object sender, EventArgs e)
        {
            actionForFoodButton(28);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            actionForFoodButton(29);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            actionForFoodButton(30);
        }

        private void button46_Click(object sender, EventArgs e)
        {
            actionForFoodButton(31);
        }

        private void button47_Click(object sender, EventArgs e)
        {
            actionForFoodButton(32);
        }

        private void button48_Click(object sender, EventArgs e)
        {
            actionForFoodButton(33);
        }

        private void button49_Click(object sender, EventArgs e)
        {
            actionForFoodButton(34);
        }

        private void button50_Click(object sender, EventArgs e)
        {
            actionForFoodButton(35);
        }

        private void button41_Click(object sender, EventArgs e)
        {
            actionForFoodButton(36);
        }

        private void button42_Click(object sender, EventArgs e)
        {
            actionForFoodButton(37);
        }

        private void button43_Click(object sender, EventArgs e)
        {
            actionForFoodButton(38);
        }
        private void button44_Click(object sender, EventArgs e)
        {
            actionForFoodButton(39);
        }

        


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void display_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Copy all this code to "pictureBox1_Click(object sender, EventArgs e)"
            myParent.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            myParent.Show();
            this.Hide();
        }
    }
}
