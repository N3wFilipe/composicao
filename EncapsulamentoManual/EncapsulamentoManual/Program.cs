using System;
using System.Globalization;

namespace EncapsulamentoManual
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("tv", 500.00, 10);

            p.SetNome("Tv 4k");

            Console.WriteLine(p.GetNome());
            Console.WriteLine(p.GetPreco());
            Console.WriteLine(p.GetQuantidade());
        }
    }
}
