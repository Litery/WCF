using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFServiceContract;

namespace WCFServiceClient
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService service = new DataService();
            Console.WriteLine("Liczba 1 = ");
            double value1 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Liczba 2 = ");
            double value2 = Double.Parse(Console.ReadLine());

            double result = service.Add(value1, value2);
            Console.WriteLine();
            result = service.Subtract(value1, value2);
            Console.WriteLine();
            result = service.Multiply(value1, value2);
            Console.WriteLine();
            result = service.Divide(value1, value2);
            Console.WriteLine();
            Console.ReadLine();

            //service.Close();
        }
    }
}
