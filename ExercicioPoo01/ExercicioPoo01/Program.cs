using System;

namespace ExercicioPoo01
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1, p2;
            p1 = new Pessoa();
            p2 = new Pessoa();

            Console.WriteLine("Dados da 1ª pessoa: ");
            Console.Write("Nome: ");
            p1.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            p1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da 1ª pessoa: ");
            Console.Write("Nome: ");
            p2.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            p2.Idade = int.Parse(Console.ReadLine());

            if (p1.Idade > p2.Idade)
            {
                Console.WriteLine("A pessoa mais velha é " + p1.Nome + " com " + p1.Idade + " anos.");
            }
            else
            {
                Console.WriteLine("A pessoa mais velha é " + p2.Nome + " com " + p2.Idade + " anos.");
            }
        }
    }
}
