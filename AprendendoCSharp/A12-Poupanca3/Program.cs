using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A12_Poupanca3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 12 - Calcula poupança 3");

            double fatorRendimento = 1.0036;
            double valorInvestido = 1000;


            for (int contadorAno = 1; contadorAno <= 5; contadorAno++)
            {
                for (int contadorMes = 1; contadorMes <= 12; contadorMes++)
                {
                    valorInvestido *= fatorRendimento;
                }

                fatorRendimento += 0.0010;
            }

            Console.WriteLine("Ao término do investimento, vovê terá R$" + valorInvestido);

            Console.ReadLine();
        }
    }
}
