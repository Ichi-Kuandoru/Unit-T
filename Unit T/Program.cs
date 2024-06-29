﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_Tasks
{
    public class LatinAlphabetString
    {
        public static string GetLatinAlphabetString(int n)
        {
            if (n < 1 || n > 26)
                throw new ArgumentException("N должно быть от 1 до 26 включительно.");

            string result = "";
            for (int i = 0; i < n; i++)
            {
                result += (char)('A' + i);
            }
            return result;
        }
    }

    public class QuadraticEquationSolver
    {
        public static double[] SolveQuadraticEquation(double a, double b, double c)
        {
            if (a == 0)
                throw new ArgumentException("число не может быть равно 0 для квадратного уравнения.");

            double discriminant = b * b - 4 * a * c;
            if (discriminant > 0)
            {
                double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                return new double[] { x1, x2 };
            }
            else if (discriminant == 0)
            {
                double x = -b / (2 * a);
                return new double[] { x };
            }
            else
            {
                return new double[0];
            }
        }
    }

    public class YearDaysCounter
    {
        public static int GetDaysInYear(int year)
        {
            if (year <= 0)
                throw new ArgumentException("Год должен быть положительным целым числом.");

            if (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0))
                return 366;
            else
                return 365;
        }
    }

    public class EmailValidator
    {
        public static bool IsValidEmail(string email)
        {
            string pattern = @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$";
            return System.Text.RegularExpressions.Regex.IsMatch(email, pattern);
        }
    }

    public class DigitsSummer
    {
        public static int SumOfDigits(string number)
        {
            if (string.IsNullOrEmpty(number))
                return 0;

            int sum = 0;
            foreach (char digit in number)
            {
                if (char.IsDigit(digit))
                {
                    sum += int.Parse(digit.ToString());
                }
            }
            return sum;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Задача на формирование строки из первых N прописных букв латинского алфавита: 
            string result = LatinAlphabetString.GetLatinAlphabetString(3);
            Console.WriteLine("1. Задача: " + result);
            //2. Задача на решение квадратного уравнения:
            double[] roots = QuadraticEquationSolver.SolveQuadraticEquation(3, 5, 6);
            Console.WriteLine("2. Задача: " + roots);
            //3. Задача на определение количества дней в году:
            int year = YearDaysCounter.GetDaysInYear(2002);
            Console.WriteLine("3. Задача: " + year);
            //4. Задача на проверку email-адреса:
            bool isValidEmail = EmailValidator.IsValidEmail("test@email");
            Console.WriteLine("4. Задача: " + isValidEmail);
            //5. Задача на вычисление суммы цифр в строке:
            int number = DigitsSummer.SumOfDigits("");
            Console.WriteLine("5. Задача: " + number);
        }
    }
}
