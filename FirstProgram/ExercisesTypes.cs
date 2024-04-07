using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProgram
{
    public static class HomeworkTypes
    {
        public static void Exercise1()
        {

            string name = "Patryk";
            string surname = "Bojarski";
            int age = 28;
            char gender = 'm';
            string pesel = "96092201395";
            string employeeNumber = "25093249053";

            Console.WriteLine("Name:" + name);
            Console.WriteLine("Surname:" + surname);
            Console.WriteLine("Age:" + age);
            Console.WriteLine("Gender:" + gender);
            Console.WriteLine("Pesel:" + pesel);
            Console.WriteLine("Employee Number:" + employeeNumber);
        }

        public static void Exercise2()
        {
            char first = 'a';
            char second = 'b';
            char third = 'c';

            Console.WriteLine(third);
            Console.WriteLine(second);
            Console.WriteLine(first);
        }

        public static void Exercise3()
        {
            double length = 10;
            double width = 10;
            double diagonal = Math.Sqrt(Math.Pow(length, 2) + Math.Pow(width, 2));
            Console.WriteLine(diagonal);
        }

        public static void Exercise4()
        {
            int number;
            number = 10;

            double number2;
            number2 = 12.5;

            string text;
            text = "SzkolaDotneta";
        }

        public static void Exercise5()
        {
            Console.WriteLine("Enter your details:");

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Surname: ");
            string surname = Console.ReadLine();

            Console.Write("Age: ");           
            int.TryParse(Console.ReadLine(), out int realAge);

            Console.Write("Gender: ");           
            char.TryParse(Console.ReadLine(), out char realGender);

            Console.Write("Heigh: ");                    
            double.TryParse(Console.ReadLine(), out double realHeight);

            Console.Write("Weight: ");
            double.TryParse(Console.ReadLine(), out double realWeight);

            Console.Write("Phone Number: ");
            long.TryParse(Console.ReadLine(), out long realPhoneNumber);

            Console.Write("E-mail address: ");
            string emailAddress = Console.ReadLine();

            Console.WriteLine(name);
            Console.WriteLine(surname);
            Console.WriteLine(realAge);
            Console.WriteLine(realGender);
            Console.WriteLine(realHeight);
            Console.WriteLine(realWeight);
            Console.WriteLine(realPhoneNumber);
            Console.WriteLine(emailAddress);
        }
    }
}






