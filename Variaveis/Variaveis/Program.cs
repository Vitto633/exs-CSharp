using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Variaveis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string meuTexto = "Hello world!";
            Console.WriteLine(meuTexto);
            Console.ReadLine();

            /* continuação */

            string corFavorita = "rosa";
            int anoSegundaGuerra = 1945;
            float velocidadeF1 = 294.48f;
            bool aconteceu = true;

            Console.WriteLine("A velocidade de um carro de fórmula um eh de: " + velocidadeF1);
            Console.WriteLine("Minha cor favorita eh: " + corFavorita);
            Console.WriteLine("A segunda guerra mundial aconteceu?: " + aconteceu);
            Console.WriteLine("O ano da segunda guerra eh: " + anoSegundaGuerra);

            velocidadeF1 = 348.29f;

            Console.WriteLine("A velocidade de um carro de fórmule um é de: " + velocidadeF1);
            Console.ReadLine();

            /*continuação*/

            dynamic variavelDinamica = "Vermelho";

            Console.WriteLine(variavelDinamica);
            Console.ReadLine();

            variavelDinamica = 123;
            
            Console.WriteLine(variavelDinamica);
            Console.ReadLine();
        }
    }
}
