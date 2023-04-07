using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingUserInput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digit a number:");
            string input1 = Console.ReadLine();
            Console.WriteLine("Digite a second number");
            string input2 = Console.ReadLine();

            int input1Converter = int.Parse(input1);
            int input2Converter = int.Parse(input2);

            int sum = input1Converter + input2Converter;

            Console.WriteLine("The result is: " + sum);
        }
    }
}
