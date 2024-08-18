using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicCS
{
    internal class session_1
    {
        public void calNumber()
        {
            Console.WriteLine("======= VER 1.0 =======");
            int num1 = 12;
            int num2 = 4;

            int sum = num1 + num2;
            Console.WriteLine($"Sum = {num1} + {num2} = {sum}");

            int differ = num1 - num2;
            Console.WriteLine($"Sum = {num1} - {num2} = {differ}");

            int product = num1 * num2;
            Console.WriteLine($"Sum = {num1} * {num2} = {product}");

            int quotient = num1 / num2;
            Console.WriteLine($"Sum = {num1} / {num2} = {quotient}");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("======= VER 1.01 =======");
            //JJ - FIRST VERSION
            Console.Write("INPUT YOUR NUMBER 1 : ");
            int Number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("INPUT YOUR NUMBER 2 : ");
            int Number2 = Convert.ToInt32(Console.ReadLine());

            int sumx = Number1 + Number2;
            Console.WriteLine(sumx);
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("======= VER 1.02 =======");
            //JJ - SECOND VERSION
            bool check1 = true;
            int number1 = 0;
            string strNumber1;
            bool isNumerical1;
            while (check1)
            {

                Console.Write("INPUT YOUR NUMBER 1 : ");
                strNumber1 = Console.ReadLine();
                
                

                isNumerical1 = int.TryParse(strNumber1, out number1);
                
               
                
                if (isNumerical1) { check1 = false; }
                else
                {
                    Console.WriteLine("YOUR INPUT IS NOT A NUMBER  : T R Y  I T  A G A I N ! ! !");
                    Console.WriteLine();
                }
            }

            bool check2 = true;
            int number2 = 0;
            string strNumber2;
            bool isNumerical2;
            while (check2)
            {
                Console.Write("INPUT YOUR NUMBER 2 : ");
                strNumber2 = Console.ReadLine();
                isNumerical2 = int.TryParse(strNumber2, out number2);
                if (isNumerical2) { check2 = false; }
                else
                {
                    Console.WriteLine("YOUR INPUT IS NOT A NUMBER  : T R Y  I T  A G A I N ! ! !");
                    Console.WriteLine();
                }
            }

            Console.WriteLine($"{number1} + {number2} = {number1 + number2}");
        }



    }

}


