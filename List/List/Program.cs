using System;
using System.Collections.Generic;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("Filipe");
            list.Add("Simone");
            list.Add("Mãe");
            list.Add("Carro");
            list.Add("Super");
            list.Insert(2, "Moto");

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("A Lista contém " + list.Count + " elementos.");

            string s2 = list.Find(x => x[0] == 'S');
            Console.WriteLine("Primeira com letra S: " + s2);

            string s1 = list.Find(Teste);
            Console.WriteLine("Primeira com letra M: " + s1);

            string s3 = list.FindLast(x => x[0] == 'M');
            Console.WriteLine("Último com a letra M: " + s3);

            int pos1 = list.FindIndex(x => x[0] == 'S');
            Console.WriteLine("Primeira posição começando com S " + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'S');
            Console.WriteLine("Última posição começando com S " + pos2);

            List<string> list2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine("--------------------------------------------------");

            foreach (string obj in list2)
            {
                Console.WriteLine(obj);
            }

            list.Remove("Moto");

            Console.WriteLine("--------------------------------------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("--------------------------------------------------");
            list.RemoveAll(x => x[0] == 'M');
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("--------------------------------------------------");
            list.RemoveAt(0);
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

        }
        static bool Teste(string s)
        {
            return s[0] == 'M';
        }
    }
}
