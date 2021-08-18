using System;
using System.Collections.Generic;

namespace Conjuntos
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();

            A.Add(3);
            A.Add(5);
            A.Add(8);
            A.Add(9);

            B.Add(3);
            B.Add(4);
            B.Add(5);

            foreach (int x in A)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("________________________________________________");

            foreach (int x in B)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("Digite um número inteiro: ");
            int N = int.Parse(Console.ReadLine());

            if (B.Contains(N))
            {
                Console.WriteLine(N + " pertence ao conjunto B.");
            }
            else
            {
                Console.WriteLine(N + " não pertence ao conjunto B.");
            }

            Console.WriteLine("____________________________________________________________");

            B.Remove(5);
            foreach (int x in B)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("____________________________________________________________");

            A.ExceptWith(B);

            foreach (int x in A)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("____________________________________________________________");

            A.UnionWith(B);
            foreach (int x in A)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("____________________________________________________________");

            A.IntersectWith(B);
            foreach (int x in A)
            {
                Console.WriteLine(x);
            }
        }

        
    }
}
