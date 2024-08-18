using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicCS
{
    internal class session_2
    {
 
        public void getRectangelArea()
        {

            Console.Write("INPUT YOUR height 1 : ");
            int Number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("INPUT YOUR width 2 : ");
            int Number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Rectangle area of width {Number2} and hight {Number1} =  {Number1 * Number2}");

        }
        public void showArimeticOperator()
        { 
            Console.Write($"Enter X: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Y: ");
            int y = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine($"++X  = {++x} ");
            Console.WriteLine($"--X  = {--x} ");
            Console.WriteLine($"++Y  = {++y} ");
            Console.WriteLine($"--Y  = {--y} ");
            Console.WriteLine($"{x} + {y} = {x + y} ");
            Console.WriteLine($"{x} - {y} = {x - y} ");
            Console.WriteLine($"{x} * {y} = {x * y} ");
            Console.WriteLine($"{x} / {y} = {x / y} ");
            Console.WriteLine($"{x} % {y} = {x % y} ");


        }

        public void getArea() {
            bool check = true;
            int optionNumber = 0;
            string userOptiont;
            bool isNumerical;
            while (check)
            {
                Console.WriteLine(" PLEASE CHOOSE FOLLWING OPTION \n 1 - Area of a Triangle \n 2 - Area of a Circle");
                Console.Write(" Yous option number : ");
                userOptiont = Console.ReadLine();
                isNumerical = int.TryParse(userOptiont, out optionNumber);
                if (isNumerical) { check = false; }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("********************************************");
                    Console.WriteLine("********** PLEASE PUT ONLY NUMBER **********");
                    Console.WriteLine("********************************************");

                }

                if(optionNumber == 1)
                {
                    Console.WriteLine();
                    Console.WriteLine(" ======================= \n 1 - Area of a Triangle \n ======================= ");
                    Console.Write($" Enter BASE: ");
                    int x = Convert.ToInt32(Console.ReadLine());
                    Console.Write(" Enter HIGHT: ");
                    int y = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($" Area of a Triangle = {(1 / 2) * x * y}");
                }
                else if (optionNumber == 2)
                {
                    Console.WriteLine();
                    Console.WriteLine(" ======================= \n 2 - Area of a Circle \n ======================= ");
                    Console.Write($" Enter radius of the circle : ");
                    int r = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($" Area of a Circle = {Math.PI * Math.Pow(r, 2)}");
                }
                else {
                    Console.WriteLine();
                    Console.WriteLine("*********************************************");
                    Console.WriteLine("****** THERE AER JUT TWO OPTION 1 OR 2 ******");
                    Console.WriteLine("*********************************************");

                    check = true;
                }
            }
        
        }

        public void general() {

            Console.Write(" Name  : ");
            string firstName = Console.ReadLine(); 
            Console.Write(" Last name  : ");
            string lastName = Console.ReadLine();
            Console.Write(" Student ID  : ");
            string StudentId = Console.ReadLine();
            string msg = $"Dear {firstName + " " + lastName}, You have a new message in your inbox. Please login student portal with your id, {StudentId}, to view the message.";
            Console.WriteLine(msg);


        }

    }

}
