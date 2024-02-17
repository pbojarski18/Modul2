using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProgram
{
    public static class HomeworkConditions
    {
        public static void Exercise1()
        {
            Console.WriteLine("Enter 2 random numbers:");
            string userInput = Console.ReadLine();
            string userInput2 = Console.ReadLine();
            int realNumber;
            int realNumber2;
            int.TryParse(userInput, out realNumber);
            int.TryParse(userInput2, out realNumber2);


            if (realNumber == realNumber2)
            {
                Console.WriteLine("Numbers are equal");
            }
            else
            {
                Console.WriteLine("Numbers aren't equal");
            }
        }
        public static void Exercise2()
        {
            Console.WriteLine("Enter random number:");
            string userInput = Console.ReadLine();
            int realNumber;
            int.TryParse(userInput, out realNumber);

            if (realNumber % 2 == 0)
            {
                Console.WriteLine("Number is even");
            }
            else
            {
                Console.WriteLine("Number is odd");
            }
        }
        public static void Exercise3()
        {
            Console.WriteLine("Enter random number");
            string userInput = Console.ReadLine();
            int realNumber;
            int.TryParse(userInput, out realNumber);

            if (realNumber >= 0)
            {
                Console.WriteLine("Number is positive");
            }
            else
            {
                Console.WriteLine("Number is negative");
            }
        }

        public static void Exercise4()
        {
            Console.WriteLine("Enter random year");
            string userInput = Console.ReadLine();
            int year;
            int.TryParse(userInput, out year);

            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                Console.WriteLine(year + "is leap year");
            }
            else
            {
                Console.WriteLine(year + "isn't leap year");
            }
        }

        public static void Exercise5()
        {
            Console.WriteLine("Enter age: ");

            if (int.TryParse(Console.ReadLine(), out int age))
            {
                if (age >= 21)
                {
                    Console.WriteLine("You can become parliamentary representative");
                }
                else
                {
                    Console.WriteLine("You can't become parliamentary representative");
                }

                if (age >= 35)
                {
                    Console.WriteLine("You can become prime minister");
                }
                else
                {
                    Console.WriteLine("You can't become primie minister");
                }

                if (age >= 30)
                {
                    Console.WriteLine("You can become senator");
                }
                else
                {
                    Console.WriteLine("You can't become senator");
                }

                if (age >= 35)
                {
                    Console.WriteLine("You can become president");
                }
                else
                {
                    Console.WriteLine("You can't become president");
                }
            }
            else
            {
                Console.WriteLine("You suck");
            }


        }

        public static void Exercise6()
        {
            Console.WriteLine("Enter height in cm");

            if (int.TryParse(Console.ReadLine(), out int height))

            {
                if (height < 140 && height > 0)
                {
                    Console.WriteLine("You're a midget");
                }
                else if (height > 140 && height < 170)
                {
                    Console.WriteLine("You're average");
                }
                else if (height > 170)
                {
                    Console.WriteLine("You're a monster");
                }
                else
                {
                    Console.WriteLine("You're kosmita");
                }
            }
            else
            {
                Console.WriteLine("Invalid height");
            }
        }

        public static void Exercise7()
        {
            Console.WriteLine("Enter number");
            double.TryParse(Console.ReadLine(), out double number);

            Console.WriteLine("Enter second number");
            double.TryParse(Console.ReadLine(), out double number2);

            Console.WriteLine("Enter third number");
            double.TryParse(Console.ReadLine(), out double number3);

            if (number >= number2 && number >= number3)
            {
                Console.WriteLine($"{number} is highest");
            }

            else if (number2 >= number && number2 >= number3)
            {
                Console.WriteLine($"{number2} is highest");
            }

            else if (number3 >= number && number3 >= number2)
            {
                Console.WriteLine($"{number3} is highest");
            }
        }

        public static void Exercise8()
        {
            Console.WriteLine("Enter your maths exam result");
            int.TryParse(Console.ReadLine(), out int mathsResult);

            Console.WriteLine("Enter your physics exam result");
            int.TryParse(Console.ReadLine(), out int physicsResult);

            Console.WriteLine("Enter your chemistry exam result");
            int.TryParse(Console.ReadLine(), out int chemistryResult);

            if (mathsResult + physicsResult + chemistryResult > 180)
            {
                Console.WriteLine("You're qualified");
            }
            else if (mathsResult + physicsResult > 150)
            {
                Console.WriteLine("You're qualified");
            }
            else if (mathsResult + chemistryResult > 150)
            {
                Console.WriteLine("You're qualified");
            }
            else
            {
                Console.WriteLine("You suck");
            }

        }

        public static void Exercise9()
        {
            Console.WriteLine("Enter random temperature");
            int.TryParse(Console.ReadLine(), out int temp);

            switch (temp)
            {
                case < 0:
                    Console.WriteLine("piździ");
                    break;
                case >= 0 and < 10:
                    Console.WriteLine("zimno");
                    break;
                case >= 10 and < 20:
                    Console.WriteLine("chłodno");
                    break;
                case >= 20 and < 30:
                    Console.WriteLine("w sam raz");
                    break;
                case >= 30 and < 40:
                    Console.WriteLine("gorąco");
                    break;
                case >= 40:
                    Console.WriteLine("wydupiam na alaske");
                    break;
                default:
                    break;
            }

        }

        public static void Exercise10()
        {
            Console.WriteLine("Enter triangle arm lenght");
            int.TryParse(Console.ReadLine(), out int a);

            Console.WriteLine("Enter another triangle arm lenght");
            int.TryParse(Console.ReadLine(), out int b);

            Console.WriteLine("Enter another triangle arm lenght");
            int.TryParse(Console.ReadLine(), out int c);

            if (a + b > c && b + c > a && a + c > b)
            {
                Console.WriteLine("Triangle can be made");
            }
            else
            {
                Console.WriteLine("Triangle impossible");
            }
        }

        public static void Exercise11()
        {
            Console.WriteLine("Enter grade between 1 and 6");
            int.TryParse(Console.ReadLine(), out int grade);

            switch (grade)
            {
                case 1:
                    Console.WriteLine("niedostateczny");
                    break;
                case 2:
                    Console.WriteLine("dopusz");
                    break;
                case 3:
                    Console.WriteLine("dosta");
                    break;
                case 4:
                    Console.WriteLine("dobry");
                    break;
                case 5:
                    Console.WriteLine("bdobry");
                    break;
                case 6:
                    Console.WriteLine("celuj");
                    break;
                default:
                    break;

            }
        }

        public static void Exercise12()
        {
            Console.WriteLine("Enter day number of the week");
            int.TryParse(Console.ReadLine(), out int day);

            switch (day)
            {
                case 1:
                    Console.WriteLine("monday");
                    break;
                case 2:
                    Console.WriteLine("tuesday");
                    break;
                case 3:
                    Console.WriteLine("wednesday");
                    break;
                case 4:
                    Console.WriteLine("thursday");
                    break;
                case 5:
                    Console.WriteLine("friday");
                    break;
                case 6:
                    Console.WriteLine("saturday");
                    break;
                case 7:
                    Console.WriteLine("sunday");
                    break;
                default:
                    break;
            }
        }

        public static void Exercise13()
        {
            Console.WriteLine("Enter random number");
            int.TryParse(Console.ReadLine(), out int a);

            Console.WriteLine("Enter another number");
            int.TryParse(Console.ReadLine(), out int b);

            Console.WriteLine("Choose one of the following options:\r\n 1. Add \r\n 2. Subtract \r\n 3. Multiply \r\n 4. Divide");
            int.TryParse(Console.ReadLine(), out int userInput);

            if (userInput == 1)
            {
                Console.WriteLine(a + b);
            }
            else if (userInput == 2)
            {
                Console.WriteLine(a - b);
            }
            else if (userInput == 3)
            {
                Console.WriteLine(a * b);
            }
            else if (userInput == 4)
            {
                Console.WriteLine(a / b);
            }
            else
            {
                Console.WriteLine("Option not available");
            }
        }
    }
}
