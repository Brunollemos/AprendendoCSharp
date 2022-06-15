using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Condicionais2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 8 - Condicionais2...");

            int idadeJoao = 18;

            //int qtdPessoas = 2;
            //bool acompanhado = qtdPessoas >= 2;

            bool acompanhado = true;

            if (idadeJoao >= 18 && acompanhado == true)
            {
                Console.WriteLine("Pode entrar.");
            }
            else
            {
                Console.WriteLine("Não pode entrar.");
            }

            Console.ReadLine();
        }
    }
}
