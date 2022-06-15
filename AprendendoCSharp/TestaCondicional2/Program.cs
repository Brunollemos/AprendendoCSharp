using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestaCondicional2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testando condicional 2...");
            
            int idade = 16;
            int qtdPessoas = 3;
            bool acompanhado = qtdPessoas >= 2;

            if (idade >= 18 && acompanhado)
            {
                Console.WriteLine("Seja bem vindo.");
            }
            else
            {
                Console.WriteLine("Infelizmente voce não pode entrar.");
            }

            Console.ReadLine();
        }
    }
}
