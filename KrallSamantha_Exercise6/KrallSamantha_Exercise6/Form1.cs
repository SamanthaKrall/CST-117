﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Author: Samantha Krall
 * CST-117
 * Exercise 6
 * Snake Eyes
 *
 * */


namespace KrallSamantha_Exercise6
{
    //see my comments in the rollButton_Click method about this variable
    public static int counter = 0;
    
    
    public partial class SnakeEyes : Form
    {
        public SnakeEyes()
        {
            InitializeComponent();
            //create 2 6-sided die
            Dice d1 = new Dice(6);
            Dice d2 = new Dice(6);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //in this method, you can simply roll each die and then update the text
        //you do need a counter. Declare a static int in this file and increment
        //every button click.  Also declare your two die objects here (see above).
        private void rollButton_Click(object sender, EventArgs e)
        {     
            //increment the counter
            counter++;
            //roll each die
            int roll1 = d1.RollDie();
            int roll2 = d2.RollDie();
            
            //change this test
            //while (Dice.sum != 1)
            while(roll1 != 1 || roll2 != 1)
            {
            //change this as needed
                die1TB.Text += Convert.ToString(Dice.result1) + "\r\n";
                die2TB.Text += Convert.ToString(Dice.result2) + "\r\n";
                rollsTB.Text = Convert.ToString(Dice.rolls);
                Dice.RollDie();
            }
            die1TB.Text += Convert.ToString(Dice.result1) + "\r\n";
            die2TB.Text += Convert.ToString(Dice.result2) + "\r\n";
            rollsTB.Text = Convert.ToString(Dice.rolls);

        }

        private void rollsTB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
