using System;
using System.Globalization;

namespace VetorParte1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o número de pessoas: ");
            int n = int.Parse(Console.ReadLine());

            double[] vect = new double[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Digite a altura da pessoa: ");
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double sum = 0.0;
            for (int i = 0; i < n; i++)
            {
                sum += vect[i];
            }

            double avg = sum / n;

            Console.WriteLine("Altura média = " + avg.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
