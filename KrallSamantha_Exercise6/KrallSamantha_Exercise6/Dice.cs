using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KrallSamantha_Exercise6
{
    public class Dice
    {
        SnakeEyes f1 = new SnakeEyes();
        public static int die1;
        public static int die2;
        private static Random diceNum = new Random();
        public static int d1;
        public static int d2;
        public static int rolls;

        public Dice(int random)
        {
            int sidesOfDie = diceNum.Next(4, 20);
        }

        public static int D1()
        {
            int die1 = d1;
            for (int i = 0; i != 1; i++)
            {
                d1 = diceNum.Next(1, 7);
            }
            return d1;
        }
        public static int D2()
        {
            int die2 = d2;
            for (int i = 0; i != 1; i++)
            {
                d2 = diceNum.Next(1,7);
            }
            return d2;
        }
        public static int result1 = 0;
        public static int result2 = 0;
        public static int sum;

        public static int RollDie()
        {
            if(d1 == 1 && d2 == 1)
            {
                MessageBox.Show("You have rolled Snake Eyes! \r\nIt took " + rolls + " rolls to acheive this.");
                sum = 1;
                return sum;
            }
            else
            {
                result1 = D1();
                result2 = D2();
                rolls++;
            }
            return rolls;
        }
        
    }
}
