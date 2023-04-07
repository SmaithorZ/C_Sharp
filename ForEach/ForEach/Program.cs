using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEach
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] fruits = {"Banana","Maçã","Uva","Manga","Tomate" };

            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }
            string searchElement = "Banana";
            int index = Array.IndexOf(fruits, searchElement);
            Console.WriteLine("Index of" + " " + searchElement + " " + ":" + " " + index);




            int[] numeros = { 10, 20, 30, 40 };

            int index2 = Array.IndexOf(numeros, 20);
            int elemento = numeros[1];

            Console.WriteLine("O índice do elemento "+elemento+" "+"É o :"+index2);

        }
    }
}
