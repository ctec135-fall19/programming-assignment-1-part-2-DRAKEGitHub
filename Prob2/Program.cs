/*
Author: Allison Drake
Date: 10/09/2019
CTEC 135: Microsoft Software Development with C#

Module 2, Programming Assignment 1 Part 2: 2 Coding Projects, Problem 2

Create a New Project called Prob2. 
Print out the numbers 1-5 using loops:
1. print 1-5 in single line for loop
2. print 1-5 on single line using while loop
3. print 1-5 using single line with do/while loop
Use Write() instead of WriteLine() in loop body and end with blank line.

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob2
{
    class Program
    {
        static void Main(string[] args)
        // Inputs: myInts 1-5, int
        // Outputs: Prints Loop Type and three versions of 1 2 3 4 5
        // Behavior: loops three ways to print 1-5
        {
            #region for loop print 1-5 and space on single line
            Console.WriteLine("For loop that prints 1-5:");
            for (int i=1; i<6; i++)            {
                Console.Write("{0} ",i);
            }
            Console.WriteLine();
            #endregion


            #region while loop print 1-5 and space on single line
            Console.WriteLine("While loop that prints 1-5:");
            int[] myInts = { 1, 2, 3, 4, 5 };
            int count = 0; 
            while(count < myInts.Length)
            {
                Console.Write("{0} ", myInts[count]);
                count++; 
            }
            Console.WriteLine();
            #endregion

            #region do/while, print 1-5 and space on single line
            Console.WriteLine("Do/While that prints 1-5:");
            count = 0;
            do
            {
                Console.Write("{0} ", myInts[count]);
                count++;
            } while (count < myInts.Length);
            Console.WriteLine();
            #endregion
        }
    }
}
