using System;

namespace Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vect = new string[] { "Filipe", "Simone", "Mãe" };

            foreach (string obj in vect)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
