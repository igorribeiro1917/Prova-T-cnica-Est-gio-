using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaTecnica_String_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Forneça o seu nome:");
            string nome = Console.ReadLine();
            if (nome.Contains("a"))
            {
                Console.WriteLine("O nome fornecido contém a letra: a");
            }
            else if (nome.Contains("A"))
            {
                Console.WriteLine("O nome fornecido contém a letra: A");
            }
            
            
            ContaA(nome);

           
            Console.ReadLine();
        }
        static void ContaA(string nome)
        {
            int contador = 0;

            foreach(char caracter in nome)
            {
                if(caracter == 'a' || caracter == 'A')
                {
                    contador++;
                }
            }   
            if(contador > 0)
            {
                Console.WriteLine($"O nome contém {contador} letras 'a'");
            }
            else
            {
                Console.WriteLine("A letra 'a' não aparece no nome fornecido");
            }
        }
       

    }
}
