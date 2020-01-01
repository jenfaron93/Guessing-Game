using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Jennifer Faron
//Assignment 3
//Guessing Game
//October 26 2017


namespace Guess_The_Number
{
   class Program
   {
      static void Main(string[] args)
      {
         Random randomNumber = new Random();

         int number = randomNumber.Next(1, 1001);

         int guess;

         string playAgain;
         void NewGame()
         {
            do
            {
               Console.WriteLine("\nGuess a number between 1 and 1000: ");
               guess = int.Parse(Console.ReadLine());

               if (guess > number)
               {
                  Console.WriteLine("Too high! \nTry again.");

               }
               else if (guess < number)
               {
                  Console.WriteLine("Too low! \nTry again.");

               }
            }

            while (guess != number);

            Console.WriteLine("Congratulations. You guessed the number!");
         }

         NewGame();
         Console.WriteLine("\nDo You want to play again? [Y/N]: ");
         playAgain = Console.ReadLine().ToUpper();

         if (playAgain == "Y")
         {
            NewGame();
         }
      }

   }
}
