using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloWorld
{
    internal class Program
    {
        static void Main(string[] args){


            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            int[] idades = new int[5];
            idades[0] = 30;
            idades[1] = 40;
            idades[2] = 50;
            idades[3] = 60;
            idades[4] = 70;


            string[] nomes = new string[5];

            nomes[0] = "Ronaldo";
            nomes[1] = "Pedro";
            nomes[2] = "João";
            nomes[3] = "Vinicius";
            nomes[4] = "Mateus";

            Console.WriteLine(cars[0]);
            Console.WriteLine(idades[4]);
            Console.WriteLine(nomes[1]);
          string nome = Console.ReadLine();

           const string carr = "Carro";
            Console.WriteLine(carr);
            for(int i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine(i);
            }
           
            if(nome == "Mateus")
            {
                Console.WriteLine("Seu nome é Mateus!");
            }
            else
            {
                Console.WriteLine("Seu nome não é Mateus :(");
            }

        }
    }
}
