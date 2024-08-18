using System.Diagnostics.CodeAnalysis;
using System.Reflection.PortableExecutable;

namespace basicCS
{
    internal class Program
    {

        static void Main(string[] args)
        {
            header();
            bool check = true;
            int optionNumber = 0;
            string userOptiont;
            bool isNumerical;
            while (check)
            {
                //Console.Clear();
                Console.WriteLine(" PLEASE CHOOSE FOLLWING OPTION");
                Console.WriteLine("  NO.1 - Session 1");
                Console.WriteLine("  NO.2 - Session 2");
                Console.WriteLine("  NO.2 - Session 3");
                Console.WriteLine("  NO.4 - Session 4");
                Console.WriteLine("  NO.5 - Session 5");
                Console.WriteLine("  NO.0 - EXIT ");
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

                switch (optionNumber) {
                    default:
                        Console.WriteLine();
                        Console.WriteLine("*********************************************");
                        Console.WriteLine("****** THERE AER JUT TWO OPTION 1 OR 2 ******");
                        Console.WriteLine("*********************************************");
                        check = true;
                        break;
                    
                    // Exit program
                    case 0: break;

                    //Session 1
                    case 1:
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine("======================= \n SESSION 1 \n======================= ");
                        session_1 objSS1 = new session_1();
                        objSS1.calNumber();
                        break;
                    
                    //Session 2
                    case 2:
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine("======================= \n SESSION 2 \n======================= ");
                        session_2 objSS2 = new session_2();
                        //objSS2.getRectangelArea();
                        //objSS2.showArimeticOperator();
                        //objSS2.getArea();
                        objSS2.general();
                        break;
                   
                    case 3:
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine("======================= \n SESSION 3 \n======================= ");
                        session_3 objSS3 = new session_3();
                        //objSS2.getRectangelArea();3
                        //objSS2.getArea();
                        objSS3.general();
                        break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine("======================= \n SESSION 4 \n======================= ");
                        session_4 objSS4 = new session_4();
                        objSS4.arrayTest();
                        objSS4.listTest();
                        objSS4.listTestfuits();
                        break;

                    case 5:
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine("======================= \n SESSION 5 \n======================= ");
                        
                        session_5 objSS5 = new session_5();
                        
                        session_5_class2 objSS5_2 = new session_5_class2();
                        objSS5_2.nameJ = " JJ (set name from other class)";

                        objSS5_2.hello_secound_class();
                        Console.WriteLine();

                        objSS5.testREF();


                        //objSS5.claculate();

                        break;

                }

            }
            
            
            Console.Write(" EXIT !!!! ");
            userOptiont = Console.ReadLine();

            footer();
        }



        static void header()
        {
            Console.WriteLine(" ================== JJ C# START ==================");
            Console.WriteLine();
        }

        static void footer()
        {
            Console.WriteLine();
            Console.WriteLine(" ================== JJ C# END ==================");
        }

    }
}