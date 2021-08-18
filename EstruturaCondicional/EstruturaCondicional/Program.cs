using System;

namespace EstruturaCondicional
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com um número inteiro:");
            int x = int.Parse(Console.ReadLine());

            if (x % 2 > 0)
            {
                Console.WriteLine("O número digitado é ímpar");
            }
            else
            {
                Console.WriteLine("O número digitado é par");
            }

            Console.WriteLine("Qual hora atual?");
            int hora = int.Parse(Console.ReadLine());

            if (hora < 12)
            {
                Console.WriteLine("Bom dia!");
            }
            else if (hora < 18)
            {
                Console.WriteLine("Boa tarde!");
            }
            else
            {
                Console.WriteLine("Boa Noite!");
            }
        }
    }
}
