using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;


namespace Martin_s_Juice_Shop
{

    public partial class Form1 : Form
    {
      
        const double oneJuice = 8.50;
        const double twoJuice = 9.50;
        const double threeJuice = 10.50;
        const double taxRate = 0.13;
        
        public Form1()
        {
            InitializeComponent();
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double numberofOne = Convert.ToDouble(textOne.Text);
                double numberofTwo = Convert.ToDouble(textTwo.Text);
                double numberofThree = Convert.ToDouble(textThree.Text);

                double taxCalculate = ((oneJuice * numberofOne) + (twoJuice * numberofTwo) + (threeJuice * numberofThree)) * taxRate;
                double totalCalculate = ((oneJuice * numberofOne) + (twoJuice * numberofTwo) + (threeJuice * numberofThree)) + taxCalculate;
                double subCalculate = ((oneJuice * numberofOne) + (twoJuice * numberofTwo) + (threeJuice * numberofThree));
               
                outputLabelOne.Text = "Tax:     " + taxCalculate.ToString("C") + "\n" + "\n" + "SubTotal:     " + subCalculate.ToString("C") + "\n" + "\n" + "Total:     " + totalCalculate.ToString("C");
                
                textBox4.Visible = true; //Teathering 
                label7.Visible = true; //shows tax total and sub
                button2.Visible = true; //Pay Button
            }

            
            catch
            {
                label8.Visible = true;
                label8.Text = "TYPE Numbers ON ALL OPTIONS";//message warns person to type values on all options
                Refresh();
                Thread.Sleep(1000);

                label8.Visible = false; 

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double numberofOne = Convert.ToDouble(textOne.Text);
                double numberofTwo = Convert.ToDouble(textTwo.Text);
                double numberofThree = Convert.ToDouble(textThree.Text);
                double taxCalculate = ((oneJuice * numberofOne) + (twoJuice * numberofTwo) + (threeJuice * numberofThree)) * taxRate;
                double totalCalculate = ((oneJuice * numberofOne) + (twoJuice * numberofTwo) + (threeJuice * numberofThree)) + taxCalculate;

                double pay = Convert.ToDouble(textBox4.Text);
                double cashBack = pay - totalCalculate;




                button3.Visible = true; //Print RECIEPT BUTTON
                outputLabelOne.Visible = true;
                outputLabelOne.Text = "Cash Back:        " + cashBack.ToString("C") + "\n" + "\n" + "Amount Owing:        " + totalCalculate.ToString("C"); 

                if (cashBack < 0) {
                    
                    button3.Visible = false;
                    label8.Visible = true;
                    label8.Text = "TYPE CORRECTAMOUNT";
                    Refresh();
                    Thread.Sleep(1000);
                    label8.Text = "";
                    label8.Visible = false;

                
                
                
                
                }
            }

            catch
            {
                label8.Visible = true;
                label8.Text = "TYPE a Number (No spaces)!!!!";
               
                Refresh();
                Thread.Sleep(1000);
                label8.Visible = false;
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                SoundPlayer chingSound = new SoundPlayer(Properties.Resources.Cha_Ching__1_);
                void okay = chingSound.Play(); 

                double numberofOne = Convert.ToDouble(textOne.Text);
                double numberofTwo = Convert.ToDouble(textTwo.Text);
                double numberofThree = Convert.ToDouble(textThree.Text);

                double taxCalculate = ((oneJuice * numberofOne) + (twoJuice * numberofTwo) + (threeJuice * numberofThree)) * taxRate;
                double totalCalculate = ((oneJuice * numberofOne) + (twoJuice * numberofTwo) + (threeJuice * numberofThree)) + taxCalculate;
                double subCalculate = ((oneJuice * numberofOne) + (twoJuice * numberofTwo) + (threeJuice * numberofThree));

                double pay = Convert.ToDouble(textBox4.Text);
                double cashBack = pay - totalCalculate;

                double priceofOne = oneJuice * numberofOne;
                double priceofTwo = twoJuice * numberofTwo;
                double priceofThree = threeJuice * numberofThree;

                label9.Visible = true; //THE RECIEPT WILL DISPLAY:
                Refresh();
                label9.Text = "\n"+"                                       The Juice Shop" + "\n" + "                                     123 Unkown Street";
                Refresh();
                Thread.Sleep(500);
                label9.Text += "\n" + "\n" + "                                 Your Reciept Is Printing";
                Refresh();
                Thread.Sleep(500);
                label9.Text += "\n" + "\n" + "     Berry Bombs:        " + numberofOne + "       " + priceofOne.ToString("C");
                Refresh();
                Thread.Sleep(500);
                label9.Text += "\n" + "\n" + "     Lemon Drops:        " + numberofTwo + "      " + priceofTwo.ToString("C");
                Refresh();
                Thread.Sleep(500);
                label9.Text += "\n" + "\n" + "     Rainbows:        " + numberofThree + "      " + priceofThree.ToString("C");

                Refresh();
                Thread.Sleep(500);
                label9.Text += "\n" + "\n" + "     Sub Total:      " + subCalculate.ToString("C");
                Refresh();
                Thread.Sleep(500);
                label9.Text += "\n" + "\n" + "     Tax Total:      " + taxCalculate.ToString("C");
                Refresh();
                Thread.Sleep(500);
                label9.Text += "\n" + "\n" + "     All Total:      " + totalCalculate.ToString("C");

                Refresh();
                Thread.Sleep(500);
                label9.Text += "\n" + "\n" + "     Paid With:      " + pay.ToString("C");
                Refresh();
                Thread.Sleep(500);
                label9.Text += "\n" + "\n" + "     Cash Back:      " + cashBack.ToString("C");
                Refresh();
                Thread.Sleep(500);
                label9.Text += "\n" + "\n" + "\n" + "               Thanks For Shopping At The Juice Shop" + "\n" + "                     Please Come Again";
                button4.Visible = true; //NEWGAME BUTTON!
            }
            catch
            {
                label8.Visible = true;
                label8.Text = "TYPE a Number (No spaces)!!!!";

                Refresh();
                Thread.Sleep(1000);
                label8.Visible = false;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            label9.Visible = false;
            label9.Text = "";
            button4.Visible = false;
            button3.Visible = false;
            button2.Visible = false;
            label7.Visible = false;
            textBox4.Visible = false;
            outputLabelOne.Visible = false;
            textOne.Text = String.Empty;
            textTwo.Text = String.Empty;
            textThree.Text = String.Empty;
            textBox4.Text = String.Empty;
            
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
