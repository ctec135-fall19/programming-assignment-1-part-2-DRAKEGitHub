/*
Author: Allison Drake
Date: 10/09/2019
CTEC 135: Microsoft Software Development with C#

Module 2, Programming Assignment 1 Part 2: 2 Coding Projects, Problem 3

Create a New Project called Prob3
Create a program that prints out actions based upon decision table.
Create methods for each action that contains print statement with text in Ouput
Methods are same level as Main()
Region 1 inside Main() is 3 nested loops to execute conditions
print a line in the innermost loop stating the conditions
Use if statements to call methods and print possible actions
Region 2 Inside Main() Use binary table method in a single for loop for 0 to 7
use a switch statement in the body with iteration variable as its value
code in each case will call the appropriate methods based on number

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob3
{
    class Program
    {
        #region main region
        static void Main(string[] args)
        {
            // header formatting
            Console.WriteLine("____________________________________________________________________");
            Console.WriteLine();
            Console.WriteLine("                       PRINTER TROUBLESHOOTER                       ");

            #region REGION ONE: Nested loops
            // Nested 3 for loops for conditions
            for (int printerPrintsCondition = 0; printerPrintsCondition <= 1; printerPrintsCondition++)
            {
                for (int lightFlashingCondition = 0; lightFlashingCondition <= 1; lightFlashingCondition++)
                {
                    for (int printerSeenCondition = 0; printerSeenCondition <= 1; printerSeenCondition++)
                    {
                        // establish what to do for boolean values 
                        if (printerPrintsCondition == 0)
                        {
                            Console.WriteLine("____________________________________________________________________");
                            Console.WriteLine();
                            Console.WriteLine("Printer Prints:\t\t\t False ");
                        } else
                        {
                            Console.WriteLine("____________________________________________________________________");
                            Console.WriteLine();
                            Console.WriteLine("Printer Prints:\t\t\t True ");
                        }

                        if (lightFlashingCondition == 0)
                        {
                            Console.WriteLine("Red Light Flashing:\t\t False ");
                        } else
                        {
                            Console.WriteLine("Red Light Flashing:\t\t True ");
                        }

                        if (printerSeenCondition == 0)
                        {
                            Console.WriteLine("Printer seen by Computer:\t False ");
                            Console.WriteLine();
                            Console.WriteLine("Possible Actions:");
                        } else
                        {
                            Console.WriteLine("Printer seen by Computer:\t True ");
                            Console.WriteLine();
                            Console.WriteLine("Possible Actions:");
                        }

                        // Variations of table conditions and calls actions 
                        if (printerPrintsCondition == 0 && lightFlashingCondition == 1 && printerSeenCondition == 0)
                        {
                            CheckPrinterCable();
                            CheckSoftwareInstalled();
                            CheckInk();
                        }
                        if (printerPrintsCondition == 0 && lightFlashingCondition == 1 && printerSeenCondition == 1)
                        {
                            CheckInk();
                            CheckPaperJam();
                        }
                        if (printerPrintsCondition == 0 && lightFlashingCondition == 0 && printerSeenCondition == 0)
                        {
                            CheckPowerCable();
                            CheckPrinterCable();
                            CheckSoftwareInstalled();
                        }
                        if (printerPrintsCondition == 0 && lightFlashingCondition == 0 && printerSeenCondition == 1)
                        {
                            CheckPaperJam();
                        }
                        if (printerPrintsCondition == 1 && lightFlashingCondition == 1 && printerSeenCondition == 0)
                        {
                            CheckSoftwareInstalled();
                        }
                        // case 5
                        if (printerPrintsCondition == 1 && lightFlashingCondition == 1 && printerSeenCondition == 1)
                        {
                            CheckInk();
                        }
                        // case 6
                        if (printerPrintsCondition == 1 && lightFlashingCondition == 0 && printerSeenCondition == 0)
                        {
                            CheckSoftwareInstalled();
                        }
                        // case 7
                        if (printerPrintsCondition == 1 && lightFlashingCondition == 0 && printerSeenCondition == 1)
                        {
                            NoPrinterIssue();
                        }
                    }
                }
            }
            #endregion
            // end of region one formatting
            Console.WriteLine("____________________________________________________________________");
            Console.WriteLine();

            #region REGION TWO: Switch in a loop
            // establish for loop with integer of 7 for code table 
            for(int i=0; i <=7; i++)
            {
                Console.WriteLine();
                switch (i)
                {
                    case 0:
                        Console.WriteLine("Printer Prints = No, Red Light Flashing = No, Printer Seen = No:");
                        Console.WriteLine("Possible Actions:");
                        CheckPowerCable();
                        CheckPrinterCable();
                        CheckSoftwareInstalled();
                        break;
                    case 1:
                        Console.WriteLine("Printer Prints = No, Red Light Flashing = No, Printer Seen = Yes:");
                        Console.WriteLine("Possible Actions:");
                        CheckPaperJam();
                        break;
                    case 2:
                        Console.WriteLine("Printer Prints = No, Red Light Flashing = Yes, Printer Seen = No:");
                        Console.WriteLine("Possible Actions:");
                        CheckPrinterCable();
                        CheckSoftwareInstalled();
                        CheckInk();
                        break;
                    case 3:
                        Console.WriteLine("Printer Prints = No, Red Light Flashing = Yes, Printer Seen = Yes:");
                        Console.WriteLine("Possible Actions:");
                        CheckInk();
                        CheckPaperJam();
                        break;
                    case 4:
                        Console.WriteLine("Printer Prints = Yes, Red Light Flashing = No, Printer Seen = No:");
                        Console.WriteLine("Possible Actions:");
                        CheckSoftwareInstalled();
                        break;
                    case 5:
                        Console.WriteLine("Printer Prints = Yes, Red Light Flashing = No, Printer Seen = Yes:");
                        Console.WriteLine("Possible Actions:");
                        NoPrinterIssue();
                        break;
                    case 6:
                        Console.WriteLine("Printer Prints = Yes, Red Light Flashing = Yes, Printer Seen = No:");
                        Console.WriteLine("Possible Actions:");
                        CheckPaperJam();
                        break;
                    case 7:
                        Console.WriteLine("Printer Prints = Yes, Red Light Flashing = Yes, Printer Seen = Yes:");
                        Console.WriteLine("Possible Actions:");
                        CheckInk();
                        break;
                }
                Console.WriteLine("____________________________________________________________________");
                Console.WriteLine();
            }
            #endregion
        }
        #endregion

        #region Actions
        // establish actions to call on same level as Main()
        static void CheckPowerCable()
        {
            Console.WriteLine("Check the power cable connection.");
        }
        static void CheckPrinterCable()
        {
            Console.WriteLine("Check printer to computer cable connection.");
        }
        static void CheckSoftwareInstalled()
        {
            Console.WriteLine("Make sure the correct printer software is installed.");
        }
        static void CheckInk()
        {
            Console.WriteLine("Check or replace the ink.");
        }
        static void CheckPaperJam()
        {
            Console.WriteLine("Check for a paper jam.");
        }
        static void NoPrinterIssue()
        {
            Console.WriteLine("Everything is working as intended.");
        }
        #endregion  
    }
}
