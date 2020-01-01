using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Jennifer Faron
//Assignment 3
//Displaying a Bar Chart
//October 26 2017

namespace DisplayingBarChart
{
   class Program
   {
      static void Main(string[] args)
      {

         int number;
         int count = 1;


         while (count < 4)
         {
            Console.WriteLine("\n\nEnter a number between 1 and 30: ");
            number = int.Parse(Console.ReadLine());

            if (number > 30 || number == 0)
            {
               Console.WriteLine("This number is not between 1 and 30.\n Please reenter.");
            }
            else
            {
               for (int Asterik = 0; Asterik < number; ++Asterik)
               {
                  Console.Write("*");
               }

               count++;
            }
         }

      }
   }
}
