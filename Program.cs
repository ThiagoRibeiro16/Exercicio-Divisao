using System;

namespace Exercicio_Divisao
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double numerador , denominador , resultado; 

            Console.WriteLine("Simulador de divisão\n");

            Console.Write("Digite o numerador....: ");
           numerador = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nDigite o denominador..: ");
            denominador = Convert.ToDouble(Console.ReadLine());

            if (numerador > 0 && denominador > 0)
            {
                resultado =  numerador / denominador;

               Console.WriteLine($"\n{numerador} dividido por {denominador} é {resultado}");
             }
            
            else
            {
               Console.WriteLine("\nNão é possível dividir por zero");
               
            }

                    Console.WriteLine("\nObrigado por utilizar nosso simulador");
        }

    }
}
