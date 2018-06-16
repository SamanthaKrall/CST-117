using System;
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
    public partial class SnakeEyes : Form
    {
        public SnakeEyes()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rollButton_Click(object sender, EventArgs e)
        {            
            while (Dice.sum != 1)
            {
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
