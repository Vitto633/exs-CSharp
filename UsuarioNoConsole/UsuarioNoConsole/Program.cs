using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsuarioNoConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva o seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Olá " + nome + " seja bem vindo!");
            Console.ReadLine();
        }
    }
}
