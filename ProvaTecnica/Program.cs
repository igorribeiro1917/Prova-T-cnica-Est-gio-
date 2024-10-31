using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaTecnica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um número:");

            if (int.TryParse(Console.ReadLine(), out int numero))
            {
                if (VerificaFibonacci(numero) == true)
                {
                    Console.WriteLine($"O número {numero} pertence a sequência de Fibonacci");
                }
                else
                {
                    Console.WriteLine($" O número {numero} não pertence a sequência de Fibonacci");
                }
            }
            else
            {
                Console.WriteLine("Informe um número inteiro válido");
            }

            Console.ReadLine();
        }
        static bool VerificaFibonacci(int numero)
        {
            if(numero < 0)
            {
                return false;
            }
            List<int> sequenciafibonacci = new List<int> {0, 1};

            while (true)
            {
                int proximoFib = sequenciafibonacci[sequenciafibonacci.Count - 1] + sequenciafibonacci[sequenciafibonacci.Count - 2];
              
                sequenciafibonacci.Add(proximoFib);
                if(proximoFib == numero)
                {
                    break;
                }   
                
            }
            return sequenciafibonacci.Contains(numero);
        }



    }
}
