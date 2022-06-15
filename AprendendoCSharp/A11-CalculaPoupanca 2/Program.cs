using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A11_CalculaPoupanca_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 11 - Calcula poupança 2");

            double valorInvestido = 1000;

            for (int contadorMes = 1; contadorMes <= 12; contadorMes++)
            {
                if (contadorMes == 1)
                {
                    valorInvestido *= 1.0036;
                    Console.WriteLine("Após " + contadorMes + " mês, você terá R$" + valorInvestido + " Reais");
                 
                }
                else
                {
                    valorInvestido *= 1.0036;
                    Console.WriteLine("Após " + contadorMes + " mêses, você terá R$" + Math.Round(valorInvestido) + " Reais");
                    
                }

            }

            Console.ReadLine();
        }
    }
}
