using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    internal class Program
    {
       static void Main(string[] args)
        {

            MyFunction();

            Console.WriteLine(SayHi());

        }

         public static void MyFunction(string nome = "Mateus", int idade = 22)
        {
            

            for(int i = 0; i <= 20; i++)
            {
                Console.WriteLine(nome+idade);
            }

            
        }

        public static string SayHi()
        {
            return "Hi" ;
        }
    }
}
