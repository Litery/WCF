using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFServiceContract
{
    [ServiceContract]
    public interface IData2
    {
        
        [OperationContract]
        string ToUpperCase(string a);
        [OperationContract]
        string ToLowerCase(string a);
        [OperationContract]
        int LetterCount(string a, char b);
        [OperationContract]
        int Fibonacci(int number);

    }
    [ServiceContract]
    public interface IData
    {
        [OperationContract]
        double Add(double n1, double n2);
        [OperationContract]
        double Subtract(double n1, double n2);
        [OperationContract]
        double Multiply(double n1, double n2);
        [OperationContract]
        double Divide(double n1, double n2);
        [OperationContract]
        string Concat(string a, string b);
        [OperationContract]
        string Shuffle(string a, string b);
    }
}

