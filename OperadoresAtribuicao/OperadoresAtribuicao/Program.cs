using System;

namespace OperadoresAtribuicao
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            Console.WriteLine(a);
            a += 2;
            Console.WriteLine(a);
            a -= 2;
            Console.WriteLine(a);
            a *= 2;
            Console.WriteLine(a);
            a /= 2;
            Console.WriteLine(a);
            a %= 2;
            Console.WriteLine(a);

            string s = "ABC";
            Console.WriteLine(s);

            //+= serve tbm para concatenação de strings
            s += "DEF";
            Console.WriteLine(s);

        }
    }
}
