using System;
using System.Globalization;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("tv", 500.00, 10);

            p.Nome ="Tv 4k";

            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);
            Console.WriteLine(p.Quantidade);
        }
    }
}
