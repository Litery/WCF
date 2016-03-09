﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFServiceContract
{
    public class CalculatorService : ICalculator
    {
        public double Add(double n1, double n2)
        {
            double result = n1 + n2;
            Console.WriteLine(n1 + " + " + n2 + " = " + result);
            return result;
        }
        public double Subtract(double n1, double n2)
        {
            double result = n1 - n2;
            Console.WriteLine(n1 + " - " + n2 + " = " + result);
            return result;
        }
        public double Multiply(double n1, double n2)
        {
            double result = n1 * n2;
            Console.WriteLine(n1 + " * " + n2 + " = " + result);
            return result;
        }
        public double Divide(double n1, double n2)
        {
            double result = n1 / n2;
            Console.WriteLine(n1 + " / " + n2 + " = " + result);
            return result;
        }
    }
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}