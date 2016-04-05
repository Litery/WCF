using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFServiceContract
{
    public class DataService : IData
    {
        public double Add(double n1, double n2)
        {
            double result = n1 + n2;
            return result;
        }
        public double Subtract(double n1, double n2)
        {
            double result = n1 - n2;
            return result;
        }
        public double Multiply(double n1, double n2)
        {
            double result = n1 * n2;
            return result;
        }
        public double Divide(double n1, double n2)
        {
            double result = n1 / n2;
            return result;
        }
        public string Concat(string a, string b)
        {
            string result = a + b;
            return result;
        }

        public string Shuffle(string a, string b)
        {
            string word = a + b;
            Random num = new Random();
            string result = new string(word.ToCharArray().OrderBy(s => (num.Next(2) % 2) == 0).ToArray());
            return result;

        }
    }

    public class DataService2 : IData2
    {
        public string ToUpperCase(string a)
        {
            return a.ToUpper();
        }

        public string ToLowerCase(string a)
        {
            return a.ToLower();
        }

        public int LetterCount(string a, char b)
        {
            int result = 0;
            foreach (char x in a)
            {
                if (x == b)
                    result++;
            }
            return result;
        }

        public int Fibonacci(int number)
        {
            if (number == 1 || number == 2)
            {
                return 1;
            }
            int n1 = 1, n2 = 1, fib = 1;
            for (int i = 3; i <= number; i++)
            {
                fib = n1 + n2;
                n1 = n2;
                n2 = fib;

            }
            return fib;
        }

        public int Factorial(int number)
        {
            int result = number;
            for (int i = 1; i < number; i++)
            {
                result = result * i;
            }
            return result;
        }
    }
}
