using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversoesEOutrosTiposNUmericos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executanfo o projeto 4");

            double salario;
            salario = 1200.50;

            // O int é uma variável que suporta valores de 32 bits
            int salarioEmInteiro = (int)salario;
            Console.WriteLine(salarioEmInteiro);

            // O long é uma variável que suporta valores de 64 bits
            long idade = 13000000000000;
            Console.WriteLine(idade);   
            

            // O short é uma variável que suporta valores de 16 bits
            short quantidadeProdutos = 15000;
            Console.WriteLine(quantidadeProdutos);

            float altura = 1.80f;
            Console.WriteLine(altura);

            Console.ReadLine();
        }
    }
}
