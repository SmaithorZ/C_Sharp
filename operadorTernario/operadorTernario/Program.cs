using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchCase 
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int dia = 2;



            switch (dia)
            {

                case 0:
                    Console.WriteLine("Domingo");
                    break;

                case 1:
                    Console.WriteLine("Segunda");
                    break;

                case 2:
                    Console.WriteLine("Terça");
                    break;

                case 3:
                    Console.WriteLine("Quarta");
                    break;

                case 4:
                    Console.WriteLine("Quinta");
                    break;

                case 5:
                    Console.WriteLine("Sexta");
                    break;

                case 6:
                    Console.WriteLine("Sábado");
                    break;

                default:
                    Console.WriteLine("[ERRO], Dia invalido");
                     break;

            }



        }
    }
}
