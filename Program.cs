using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoapApi481.CalcService; 

namespace SoapApi481
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new CalculatorSoapClient();

            int result = client.Add(5, 3);

            Console.WriteLine($"5 + 3 = {result}");
        }
    }
}
