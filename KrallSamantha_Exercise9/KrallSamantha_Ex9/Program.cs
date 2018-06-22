﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Edited by <Samantha Krall>
namespace KrallSamantha_Ex9
{
    class Program
    {
        static void Main(string[] args)
        {
            // make some sets 
            Set A = new Set();
            Set B = new Set();
            // put some stuff in the sets
            Random r = new Random();
            for(int i = 0; i < 10; i++)
            {
                // Only 4 elements added to A, but looping 10 times
                //Changed A to have ten elements
                //A.addElement(r.Next(4));
                A.addElement(r.Next(10));
                B.addElement(r.Next(12));
            }
            // display each set and the union
            Console.WriteLine("A:" + A);
            Console.WriteLine("B:" + B);
            Console.WriteLine("A union B:" + A.union(B));
            // display original sets (should be unchanged)
            Console.WriteLine("After union operation");
            Console.WriteLine("A:" + A);
            Console.WriteLine("B:" + B);
            //Allows for the sets to be displayed
            Console.ReadKey();
        }
    }    
}
