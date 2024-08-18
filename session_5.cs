using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace basicCS
{
    class session_5
    {

        public void claculate() {
            Console.Clear();
            bool check = true;
            while (check) {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(" PLEASE CHOOSE YOUR OPTION");
                Console.WriteLine("  NO.1  [+] Summation ");
                Console.WriteLine("  NO.2  [-] Subtrction ");
                Console.WriteLine("  NO.2  [*] Multiplication ");
                Console.WriteLine("  NO.4  [/] Division ");
                Console.WriteLine("  NO.5  [//] Floor Division ");
                Console.WriteLine("  NO.6  [%] Modulus  ");
                Console.WriteLine("  NO.7  [**] Power-Of ");
                Console.WriteLine("  NO.8  Area of Square");
                Console.WriteLine("  NO.9  Area of Circle");
                Console.WriteLine("  NO.10 Area of Triangle");
                Console.WriteLine("  NO.11 Area of Rectangle");
                Console.WriteLine("  NO.0  EXIT ");
                Console.Write("Yous option number : ");
                int userOptiont = Convert.ToInt32(Console.ReadLine());

                if (userOptiont <= 7 && userOptiont != 0)
                {

                    calculateNumber(userOptiont);

                }
                else if (userOptiont >= 8)
                {
                    calculateArea(userOptiont);
                }
                else {

                    check = false;

                }

                Console.WriteLine();

            }
           
        }
        
        static void calculateNumber(int userOptiont) {

            Console.Write("Enter your first number: ");
            double number1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter your second number: ");
            double number2 = Convert.ToDouble(Console.ReadLine());

            switch (userOptiont)
            {
                default:
                    break;

                case 1:
                    Console.WriteLine($"Sum = {number1} + {number2} = {number1 + number2}");
                    break;
                case 2:
                    Console.WriteLine($"Sum = {number1} - {number2} = {number1 - number2}");
                    break;
                case 3:
                    Console.WriteLine($"Sum = {number1} * {number2} = {number1 * number2}");
                    break;
                case 4:
                    Console.WriteLine($"Sum = {number1} / {number2} = {number1 / number2}");
                    break;
                case 5:
                    Console.WriteLine($"Sum = {number1} // {number2} = {number1 / number2}");
                    break;
                case 6:
                    Console.WriteLine($"Sum = {number1} % {number2} = {number1 % number2}");
                    break;
                case 7:
                    Console.WriteLine($"Sum = {number1} ** {number2} = {Math.Pow(number1, number2)}");
                    break;

            }
   
        }

        static void calculateArea(int userOptiont) {

            switch (userOptiont) { 
            
                case 8:
                    Console.Clear();
                    Console.WriteLine(" ====  Area of Square ==== ");
                    Console.Write("length: ");
                    double length_ = Convert.ToDouble(Console.ReadLine());
                    Console.Write($"area of Square  = {Math.Pow(length_, 2)}");
                    break;

                case 9:
                    Console.Clear();
                    Console.WriteLine(" ====  Area of Circle ==== ");
                    Console.Write("Radius: ");
                    double radius_ = Convert.ToDouble(Console.ReadLine());
                    Console.Write($"area of Circle  = { Math.PI * Math.Pow(radius_,2)}");
                    break;

                case 10:
                    Console.Clear();
                    Console.WriteLine(" ====  Area of Triangle ==== ");
                    Console.Write("base: ");
                    double base_ = Convert.ToDouble(Console.ReadLine());
                    Console.Write("height: ");
                    double height_ = Convert.ToDouble(Console.ReadLine());
                    Console.Write($"area of Triangle  = { 0.5 * base_ * height_}");
                    break;

                case 11:
                    Console.Clear();
                    Console.WriteLine(" ====  Area of Rectangle ==== ");
                    Console.Write("base: ");
                    double length2_ = Convert.ToDouble(Console.ReadLine());
                    Console.Write("height: ");
                    double wifth_ = Convert.ToDouble(Console.ReadLine());
                    Console.Write($"area of Rectangle  = {length2_ * wifth_}");

                    break;

                default:
                    break;

            }


        }
  
        public int ReadInt(){

            while (true)
            {
                try
                {
                    Console.Write("Number : ");
                    int input = Convert.ToInt32(Console.ReadLine());
                    //return input;
                    if (input == 999)
                    {
                        Console.WriteLine("BYE  !");
                        break;
                    }

                }
                catch
                {
                    Console.Write("Invalid format. Enter an integer: ");
                }
            }

            return 0;
        }

        public void testREF(){
            int number = 10;

            Console.WriteLine("Original value of number: " + number);

            // Call the method with the ref modifier
            int xReturm = ModifyNumber(ref number); // remove ref from here and form the method and run again 

            Console.WriteLine($"Modified value of number: {number} / return x = {xReturm} " );
        }

        static int ModifyNumber(ref int num){// remove ref and run again 

            // Modify the value of the parameter directly
            num = 20;
            return 999;

        }

    }

    class session_5_class2
    {
        public string nameJ;
        public void hello_secound_class() {
            Console.WriteLine("HELLO I AM IN A SECOUND CLASS IN SESSION_5 File !!!" + nameJ);
        }
    }



}
