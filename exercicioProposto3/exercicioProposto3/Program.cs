using System;
using System.Globalization;

namespace exercicioProposto3
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario func = new Funcionario();

            Console.WriteLine("Digite os dados do funcionário: ");
            Console.Write("Nome: ");
            func.Nome = Console.ReadLine();
            Console.Write("Salário Bruto: ");
            func.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            func.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Funcionário: " + func + ".");

            Console.WriteLine();
            Console.WriteLine("Digite a porcentagem para aumentar o salário: ");
            double percentual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            func.AumentarSalario(percentual);

            Console.WriteLine();
            Console.WriteLine("Funcionário: " + func + ".");

        }
    }
}
