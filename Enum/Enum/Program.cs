using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    internal class Program
    {
        enum Cor
        {
            Vermelho, //0
            Amarelo, //1
            Verde, //2
            Roxo //3
        }

        enum Carros
        {
            Saveiro,
            Ferrari,
            Gol,
            Toyota
        }
        static void Main(string[] args)
        {

            Cor minhaCor = Cor.Roxo;
            Carros meuCarro = Carros.Toyota;

            Console.WriteLine(meuCarro + " "+ minhaCor);

           

           

            
        }

       
    }
}
