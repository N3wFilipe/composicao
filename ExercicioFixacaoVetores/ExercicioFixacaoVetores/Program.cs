using System;

namespace ExercicioFixacaoVetores
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] quarto = new int[9];

            Console.Write("quantos quartos deseja alugar? ");
            int n = int.Parse(Console.ReadLine());

            Pemsionista[] vect = new Pemsionista[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Digite o nome do pensionista: ");
                string name = Console.ReadLine();
                Console.WriteLine("Digite o email: ");
                string email = Console.ReadLine();
                Console.WriteLine("Escolha o quarto que quer usar:");
                int numero = int.Parse(Console.ReadLine());
                vect[i] = new Pemsionista { Nome = name, Email = email, Numero = numero };
            }

            for (int i = 0; i < )
        }
    }
}
