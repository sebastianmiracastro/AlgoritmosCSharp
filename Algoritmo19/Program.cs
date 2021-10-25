using System;

namespace Algoritmo19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pongale Un Limite Al Contador: ");
            int Num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= Num; i++)
            {
                for(int x = 1; x <= i; x++)
                {
                    Console.Write(" " + x);
                }
                Console.WriteLine();
            }

        }
    }
}
