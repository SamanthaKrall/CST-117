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
        //This is not exactly right - you need to think of the Die as an object.  Your client program (the form) uses two
        //such objects.  You want to instantiate the two objects there, not here.  This is a description of the Die class.
        //The only attribute this class needs is an integer for the number of sides:
       
        //Lydia's code
        private int numsides;
        
        SnakeEyes f1 = new SnakeEyes();
        public static int die1;
        public static int die2;
        private static Random diceNum = new Random();
        public static int d1;
        public static int d2;
        public static int rolls;
        
        //this is your constructor.  It should take an int for the number of sides of the new die you are instantiating
        public Dice(int random)
        {
            //updated by Lydia
            int sidesOfDie = random; //diceNum.Next(4, 20);
            
            //it also makes good sense to use some exception handling here in case the user passes in
            //an illegal value for the number of sides.
        }
        
        //one method is needed to roll a die 
        //Lydia's code
        public int rollDie(){
            //generate a random number between 0 and sidesOfDie-1
            int val = random(0, sidesOfDie);
            return val + 1;
        }
        

        //You don't need any of the rest of this.  
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
