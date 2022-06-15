using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LacoRepeticaoFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int contador = 0; contador <= 10; contador++)
            {
                Console.WriteLine(contador);
            }

            for (int linha = 0; linha < 5; linha++)
            {
                for (int coluna = 0; coluna < 5; coluna++)
                {
                    if (coluna > linha)
                    {
                        break;                    
                    }
                    Console.Write(linha);
                }
            }

            Console.ReadLine();
        }
    }
}
