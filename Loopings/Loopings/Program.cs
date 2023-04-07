using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loopings
{
    internal class Program
    {
        static void Main(string[] args)
        {


            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i); //vai rodar até chegar no número 9.
            }

            int c = 1;

            while (c <= 6)
            {
                Console.WriteLine(c);
                c++;

            }


            int frutas = 10;

            do
            {

                Console.WriteLine(frutas);
                frutas++;

            } while (frutas <= 20);
            //Resultado: 10 11 12 13 14 15 16 17 18 19 20


        }
    }
}
