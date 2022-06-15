using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPRFfake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salario = 3300.00;

            if (salario >= 1900.00 && salario <= 2800.00)
            {
                Console.WriteLine("IR é de 7.5% e pode deduzir na declaração o valor de R$ 142.");
            }
            else if (salario >= 2800.01 && salario <= 3751.00)
            {
                Console.WriteLine("IR é de 15% e pode deduzir na declaração o valor de R$ 350.");
            }
            else if (salario >= 3751.01 && salario <= 4664.00)
            {
                Console.WriteLine("IR é de 22.5% e pode deduzir na declaração o valor de R$ 636.");
            }

            Console.ReadLine();

        }
    }
}
