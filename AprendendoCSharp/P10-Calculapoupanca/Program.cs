using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10_Calculapoupanca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 10 - Calcula poupança");

            double valorInvestido = 1000;
            int contadorMes = 1;

            while (contadorMes <= 3)
            {
                if (contadorMes == 1)
                {
                    valorInvestido = valorInvestido + valorInvestido * 0.0036;
                    Console.WriteLine("Após " + contadorMes + " mês, você terá R$" + valorInvestido + " Reais");
                    contadorMes++;
                }
                else
                {
                    valorInvestido = valorInvestido + valorInvestido * 0.0036;
                    Console.WriteLine("Após " + contadorMes + " mêses, você terá R$" + Math.Round(valorInvestido) + " Reais");
                    contadorMes++;
                }
                
            }
                
                

            // 0.36% = 0.0036
            //valorInvestido = valorInvestido + valorInvestido * 0.0036;

            //Console.WriteLine("Após 1 mês, você terá R$" + valorInvestido + " Reais");

            //valorInvestido = valorInvestido + valorInvestido * 0.0036;
            //Console.WriteLine("Após 2 mês, você terá R$" + valorInvestido + " Reais");

            Console.ReadLine();
        }
    }
}
