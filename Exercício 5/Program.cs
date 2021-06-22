using System;

namespace exercicio5___repetitiva
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número para ver a tabuada");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Tabuada do " + numero);

			for (int x = 1; x <= 10; x++)
            {
                for (var o = 1; o <= 1; o++)
                {
                    Console.WriteLine(numero + " * " + x + " = " + numero * x);
                }
            }
        }
    }
}