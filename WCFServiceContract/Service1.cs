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
}
