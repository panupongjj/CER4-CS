using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicCS
{
    internal class session_3
    {
        public void general()
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("1. print Hello, 2. Exit");
                string YourChoice = Console.ReadLine();
                if (YourChoice == "1")
                {
                    Console.WriteLine("Hello");
                }
                else if (YourChoice == "2")
                {
                    Console.WriteLine("See you next time");
                    exit = true;
                }
            }
        }


        public void numberGame() { 
        
            Random rnd = new Random();
            int X = rnd.Next(1,10);
            int i = 0;
            bool guessResult = false;
            while (i<5 && guessResult == false) {
                Console.Write("Guess the number :");
                int guess = Convert.ToInt32(Console.ReadLine());
                if (guess == X) { 
                    guessResult = true;
                }
                i++;
            
            }
            if (guessResult == false)
            {
                Console.WriteLine("You loos the X is:" + X);
            }
            else {
                Console.WriteLine("YOU WIN !");
            }
        }

        public void keepDoing() { 
            
        }
    }
}
