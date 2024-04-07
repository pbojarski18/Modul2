using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProgram
{
    public static class HomeworkLoops
    {
        public static void Exercise1()
        {
            //Napisz program, który sprawdzi ile jest liczb pierwszych w zakresie 0 – 100.
            for (int i = 0; i <= 100; i++)
            {
                int divider = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        divider++;
                    }
                }
                Console.WriteLine(i);
                if (divider == 2)
                {
                    Console.WriteLine($"{i} is prime");
                }
            }
        }

        public static void Exercise2()
        {
            //Napisz program, w którym za pomocą pętli do…while znajdziesz wszystkie liczby parzyste z
            //zakresu 0 – 1000.
            int a = 0;
            do
            {
                if (a % 2 == 0)
                {
                    Console.WriteLine(a);
                }
                a++;
            } while (a <= 1000);
        }

        public static void Exercise3()
        {
            //Napisz program, który zaimplementuje ciąg Fibonacciego i wyświetli go na ekranie.
            Console.WriteLine("How many Fibonacci elements");
            int.TryParse(Console.ReadLine(), out int userInput);

            if (userInput == 1)
            {
                Console.Write("0");
            }
            if (userInput == 2)
            {
                Console.Write("0 1");
            }
            if (userInput > 2)
            {


                int first = 0;
                int second = 1;

                Console.Write($"{first} {second} ");

                for (int i = 2; i < userInput; i++)
                {
                    int nextNumber = first + second;
                    Console.Write($"{nextNumber} ");

                    first = second;
                    second = nextNumber;
                }
            }
        }


        public static void Exercise4()
        {
            // Napisz program, który po podaniu liczby całkowitej wyświetli piramidę liczb od 1 do podanej
            //liczby w formie jak poniżej
            //1
            //2 3
            //4 5 6
            //7 8 9 10
            Console.WriteLine("How big pyramid");
            int.TryParse(Console.ReadLine(), out int userInput);

            int currentNumber = 1;

            for (int i = 1; currentNumber <= userInput; i++)
            {
                for (int j = 1; j <= i; j++)
                {


                    if (currentNumber > userInput)
                    {

                        break;
                    }
                    Console.Write($"{currentNumber} ");
                    currentNumber++;
                    
                }
                

                Console.WriteLine();

            }
        }


        public static void Exercise5()
        {
            //Napisz program, który dla liczb od 1 do 20 wyświetli na ekranie ich 3 potęgę.
            for (int i = 1; i <= 20; i++)
            {
                int power3 = (int)Math.Pow(i, 3);
                Console.WriteLine($"{i}^3 = {power3}");
            }
        }

        public static void Exercise6()
        {
            //Napisz program, który dla liczb od 0 do 20 obliczy sumę wg wzoru: 1 + ½ + 1 / 3 + ¼ itd
            double result = 0;

            for (int i = 1; i <= 20; i++)
            {
                result += (1.0 / (double)i);
            }
            Console.WriteLine(result);

        }

        public static void Exercise7()
        {
            Console.WriteLine("Give the length of the diagonal of the diamond:");
            if (int.TryParse(Console.ReadLine(), out int diagonalLength) && diagonalLength > 0)
            {
                int middle = (diagonalLength + 1) / 2;
                for (int i = 1; i <= diagonalLength; i++)
                {
                    int stars;
                    if (i <= middle)
                    {
                        stars = 2 * i - 1;
                    }
                    else
                    {
                        stars = 2 * (diagonalLength - i) + 1;
                    }

                    int spaces = middle - (stars + 1) / 2;

                    Console.WriteLine($"{new string(' ', spaces)}{new string('*', stars)}");
                }
            }
            else
            {
                Console.WriteLine("Invalid value.");
            }
        }

        public static void Exercise8()
        {
            //Napisz program, który odwróci wprowadzony przez użytkownika ciąg znaków. Np.
            //Testowe dane:
            //Abcdefg
            //Rezultat
            //Gfedcba
            Console.WriteLine("Enter random word");
            string userInput = Console.ReadLine();
            int stringLength = userInput.Length;
            for (int i = 0; i < stringLength; i++)
            {
                Console.Write(userInput[userInput.Length - 1 - i]);

            }
            //Console.WriteLine(userInput.ToString().Reverse().ToArray());

        }

        public static void Exercise9()
        {
            //Napisz program, który zamieni liczbę dziesiętną na liczbę binarną
            Console.WriteLine("Enter random number dziesietna");
            int.TryParse(Console.ReadLine(), out int number);
            string binary = "";
            while (number >= 1)
            {
                if (number % 2 == 0)
                {
                    binary = binary + "0";
                }
                else
                {
                    binary = binary + "1";
                }
                number = number / 2;
            }
            Console.WriteLine(binary.ToString().Reverse().ToArray());
        }

        public static void Exercise10()
        {
            //Napisz program, który znajdzie najmniejszą wspólną wielokrotność dla zadanych 2 liczb.
            Console.Write("Enter first number ");
            int.TryParse(Console.ReadLine(), out int number);
            Console.Write("Enter second number ");
            int.TryParse(Console.ReadLine(), out int number2);
            int a = 0;
            int b = 0;
            bool isDone = true;
            if (number > number2)
            {
                a = number;
                b = number2;
            }
            else
            {
                a = number2;
                b = number;
            }
            while (isDone)
            {
                if (a % b == 0)
                {
                    Console.WriteLine($"NWD = {b}");
                    isDone = false;
                }
                else
                {
                    int temp = a % b;
                    a = b;
                    b = temp;
                }
            }
            double result = number * number2 / b;
            Console.WriteLine($"NWW = {result}");
        }

        public static void Exercise11()
        {
            ////Napisz program, który znajdzie najmniejszą wspólną wielokrotność dla zadanych 2 liczb.
            Console.Write("Enter first number ");
            int.TryParse(Console.ReadLine(), out int firstNumber);
            Console.Write("Enter second number ");
            int.TryParse(Console.ReadLine(), out int secondNumber);
            bool isMultiply = true;
            for (int i = 1; isMultiply; i++)
            {
                if (i % firstNumber == 0 && i % secondNumber == 0)
                {
                    Console.WriteLine(i);
                    isMultiply = false;
                    break;
                }
            }
        }

        public static void Exercise12()
        {
            Console.WriteLine("Type anything");
            string userInput = Console.ReadLine();
            string allowedLetters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int stringLength = userInput.Length;
            string nein = "";

            for (int i = 0; i < stringLength; i++)
            {
                if (allowedLetters.Contains(userInput[i]))
                {
                    Console.Write(userInput[i]);
                }
                else
                {
                    Console.Write(nein);
                }
            }
        }

        public static void Exercise13()
        {
            Random rand = new Random();
            int drawnNumber = rand.Next(1, 101);
            int guessAttempts = 7;
            Console.WriteLine("Guessing numbers game");
            Console.WriteLine("Enter your number ");

            for (int i = 0; i <= guessAttempts; i++)
            {
                int.TryParse(Console.ReadLine(), out int userInput);
                if (userInput == drawnNumber)
                {
                    Console.WriteLine("You won");
                    break;
                }

                else if (userInput > drawnNumber)
                {
                    Console.WriteLine("Number too high, try again");

                }
                else if (userInput < drawnNumber)
                {
                    Console.WriteLine("Number too low, try again");
                }
                if (i == guessAttempts - 1)
                {
                    Console.WriteLine($"You're out of attempts, number was {drawnNumber}");
                    break;
                }
            }
        }
    }
}