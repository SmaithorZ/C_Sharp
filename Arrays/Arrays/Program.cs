using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] idades = new int[10];

            idades[0] = 10;
            idades[1] = 15;
            idades[2] = 17;
            idades[3] = 18;
            idades[4] = 50;
            idades[5] = 70;
            idades[6] = 12;
            idades[7] = 13;
            idades[8] = 90;
            idades[9] = 80;


            string[] nomes = new string[5];

            nomes[0] = "Mateus";
            nomes[1] = "Carlos";
            nomes[2] = "Ana";
            nomes[3] = "Gabriel";
            nomes[4] = "Marcela";

            Console.WriteLine(nomes[2] +" "+ "Tem"+" " + idades[3]+" "+"anos de idade!");


            string[] cars = { "Volvo", "Lamborghini", "Ferrari" };

            

            Console.WriteLine(cars[0]);

            string[] motos = new string[7];

            motos[0] = "Hayabusa";
            motos[1] = "Kawasaki";
            motos[2] = "CG150";
            motos[3] = "Kawasaki Ninja";
            motos[4] = "Moto1";
            motos[5] = "Moto2";
            motos[6] = "Moto3";


            Console.WriteLine(motos[3]);




        }
    }
}
