using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicCS
{
    internal class session_4
    {
        
        public void arrayTest() {

            int[] numbers = new int[5];
            numbers[0] = 10;
            numbers[1] = 20;
            numbers[2] = 5;
            numbers[3] = 22;
            numbers[4] = 8;

            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
            // Declare and initialize a 2D array with 3 rows and 4 columns
            int[,] matrix = new int[3, 3] {
                { 10, 3, 40 },
                { 5, 1, 7 },
                { 9, 20, 71 }
            };

            // Access and print elements of the 2D array
            Console.WriteLine("Elements of the 2D array:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
            // Declare and initialize a 3D array with dimensions 2x3x4
            
            int[,,] threeDArray = new int[2, 3, 4] {
                {
                    { 1, 2, 3, 4 },
                    { 5, 6, 7, 8 },
                    { 9, 10, 11, 12 }
                },
                {
                    { 13, 14, 15, 16 },
                    { 17, 18, 19, 20 },
                    { 21, 22, 23, 24 }
                }
             };

            Console.WriteLine("Elements of the 3D array:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 4; k++)
                    {
                        Console.Write(threeDArray[i, j, k] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }

        public void listTest() {
            // Create a list to store integers
            List<int> numbers = new List<int>();

            // Add elements to the list
            numbers.Add(10);
            numbers.Add(20);
            numbers.Add(30);
            numbers.Add(21);
            numbers.Add(20);


            // Display the elements of the list
            Console.WriteLine("Elements of the list:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            // Remove an element from the list
            numbers.Remove(20);
            numbers.Remove(20);

            // Display the updated elements of the list
            Console.WriteLine("\nElements after removing 20:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }


        }
        public void listTestfuits()
        {
            // Create a list to store integers
            List<string> fuites = new List<string>();

            // Add elements to the list
            fuites.Add("Apple");
            fuites.Add("Orange");
            fuites.Add("BlueBery");
            fuites.Add("Coconut");

  

            Console.WriteLine();
            // Display the elements of the list
            Console.WriteLine("Elements of the list:");
            foreach (string fuite in fuites)
            {
                Console.WriteLine(fuite);
            }

            // Remove an element from the list

            

            // Display the updated elements of the list
            Console.WriteLine("\nElements after removing BlueBery:");
            foreach (string fuite in fuites)
            {
                Console.WriteLine(fuite);
            }


        }

        public void general() {

            int num1 = 0, num2 = 0;
            bool validInput1 = false, validInput2 = false;

            // Loop until valid input is received for the first number
            while (!validInput1)
            {
                Console.Write("Enter the first number: ");
                string input1 = Console.ReadLine();

                if (int.TryParse(input1, out num1))
                {
                    validInput1 = true;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                }
            }

            // Loop until valid input is received for the second number
            while (!validInput2)
            {
                Console.Write("Enter the second number: ");
                string input2 = Console.ReadLine();

                if (int.TryParse(input2, out num2))
                {
                    validInput2 = true;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                }
            }

            // Calculate the sum
            int sum = num1 + num2;

            // Display the result
            Console.WriteLine("The sum of {0} and {1} is {2}.", num1, num2, sum);



        }

    }

}
