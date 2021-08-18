using System;
using System.Globalization;

namespace VetorParte2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o número de produtos que quer adicionar ao carrinho: ");
            int n = int.Parse(Console.ReadLine());

            Product[] vect = new Product[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Digite o nome do produto: ");
                string name = Console.ReadLine();
                Console.Write("Digite o valor do produto: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vect[i] = new Product { Name = name, Price = price };
            }

            double sum = 0.0;
            for(int i = 0; i < n; i++)
            {
                sum += vect[i].Price;
            }

            double avg = sum / n;
            Console.WriteLine("Preço médio = " + avg.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
