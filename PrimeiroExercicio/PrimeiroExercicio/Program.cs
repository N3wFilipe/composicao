using System;
using System.Globalization;

namespace PrimeiroExercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de Escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.00;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine($"{produto1}, cujo o preço é ${preco1:F2}");
            Console.WriteLine($"{produto2}, cujo o preço é ${preco2:F2}");
            Console.WriteLine("   ");

            Console.Write($"Registro: {idade} anos de idade, código {codigo}  e gênero: {genero}");
            Console.WriteLine("   ");

            Console.WriteLine($"Medida com oito casas decimais: {medida:F8}");
            Console.WriteLine($"Arredondando (três casas decimais): {medida:F3}");
            Console.WriteLine("Separador decimal invariant culture: " + medida.ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}
