using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

// Author: Samantha Krall
// CST-117
// June 2018

namespace KrallSamantha_Exercise10
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StreamReader testFile = new StreamReader("testFile.txt");
                string[] input = testFile.ReadToEnd().Split();
                int count = 0;
                
                foreach (string subString in input)
                {
                    if (char.IsPunctuation(subString, subString.Length - 1))
                    {
                        string modifiedString = subString.Remove(subString.Length - 1);

                        while (char.IsPunctuation(modifiedString, modifiedString.Length - 1))
                        {
                            modifiedString = modifiedString.Remove(modifiedString.Length - 1);
                        }
                        
                        if (modifiedString.EndsWith("t") || modifiedString.EndsWith("e") ||
                            modifiedString.EndsWith("T") || modifiedString.EndsWith("E"))
                        {
                            count++;
                        }
                    }
                    else 
                    {
                        
                        if (subString.EndsWith("t") || subString.EndsWith("e") ||
                            subString.EndsWith("T") || subString.EndsWith("E"))
                        {
                            count++;
                        }
                    }
                }

                Console.WriteLine("There are " + count + " words that end in 't' or 'e'");
                testFile.Close();
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.ReadLine();
            }
        }
    }
}
